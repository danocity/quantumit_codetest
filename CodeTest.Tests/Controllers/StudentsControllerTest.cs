using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest;
using CodeTest.Controllers;
using CodeTest.Models;

namespace CodeTest.Tests.Controllers
{
    [TestClass]
    public class StudentsControllerTest
    {
        [TestMethod]
        public void StudentsIndex()
        {
            // Arrange
            StudentsController controller = new StudentsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void StudentsNew()
        {
            // Arrange
            StudentsController controller = new StudentsController();

            // Act
            ViewResult result = controller.Edit(0) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void StudentsEdit()
        {
            // Arrange
            StudentsController controller = new StudentsController();

            // Act
            ViewResult result = controller.Edit(999999) as ViewResult;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void StudentsDelete()
        {
            // Arrange
            StudentsController controller = new StudentsController();

            // Act
            JsonResult result = controller.Delete(99999) as JsonResult;

            // Assert
            Assert.IsFalse(((JsonResultData)result.Data).isOK);
        }
    }
}
