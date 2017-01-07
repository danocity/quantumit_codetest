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
    public class ClassesControllerTest
    {
        [TestMethod]
        public void ClassesIndex()
        {
            // Arrange
            ClassesController controller = new ClassesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ClassesNew()
        {
            // Arrange
            ClassesController controller = new ClassesController();

            // Act
            ViewResult result = controller.Edit(0) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ClassesEdit()
        {
            // Arrange
            ClassesController controller = new ClassesController();

            // Act
            ViewResult result = controller.Edit(999999) as ViewResult;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ClassesDelete()
        {
            // Arrange
            ClassesController controller = new ClassesController();

            // Act
            JsonResult result = controller.Delete(99999) as JsonResult;

            // Assert
            Assert.IsFalse(((JsonResultData)result.Data).isOK);
        }
    }
}
