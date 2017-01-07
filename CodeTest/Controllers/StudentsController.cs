using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeTest.Models;

namespace CodeTest.Controllers
{
    public class StudentsController : Controller
    {
        private DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if ((id ?? 0) == 0)
                return View(new Student());
            Student student = db.Students.Find(id);
            if (student == null)
                return HttpNotFound();
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentName,StudentSurname,DOB,GPA")] Student student)
        {
            if (ModelState.IsValid)
            {
                if (db.Students.Any(o => o.StudentSurname == student.StudentSurname && o.Id != student.Id))
                    ModelState.AddModelError("StudentSurname", "Must be unique.");
                if ((DateTime.Now.Year-student.DOB.Year) > 80)
                    ModelState.AddModelError("DOB", "Invalid date.");

                if (ModelState.IsValid)
                {
                    if (student.Id == 0)
                        db.Students.Add(student);
                    else
                        db.Entry(student).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Student student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }
            return Json(new JsonResultData { isOK = student != null });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
