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
    public class ClassesController : Controller
    {
        private DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if ((id ?? 0) == 0)
                return View(new Class());
            Class @class = db.Classes.Find(id);
            if (@class == null)
                return HttpNotFound();
            return View(@class);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClassName,Teacher")] Class @class)
        {
            if (ModelState.IsValid)
            {
                var teacher = @class.Teacher.ToLower();
                if (!teacher.StartsWith("mr ") && !@teacher.StartsWith("ms ") && !@teacher.StartsWith("mrs "))
                    ModelState.AddModelError("Teacher", "Must start with any of these salutations: Mr, Ms, Mrs");

                if (ModelState.IsValid)
                {
                    if (@class.Id == 0)
                        db.Classes.Add(@class);
                    else
                        db.Entry(@class).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(@class);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Class @class = db.Classes.Find(id);
            if (@class != null)
            {
                db.Classes.Remove(@class);
                db.SaveChanges();
            }
            return Json(new JsonResultData { isOK = @class != null});
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
