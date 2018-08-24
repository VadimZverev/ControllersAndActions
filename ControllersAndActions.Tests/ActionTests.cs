using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Controllers;
using System.Web.Mvc;
namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ControllerTest()
        {
            // Arrange - создание контроллера
            ExampleController target = new ExampleController();

            // Act - вызов метода действия
            ViewResult result = target.Index();

            // Assert - проверка результата
            Assert.AreEqual("Hello", result.ViewBag.Message);
        }

        [TestMethod]
        public void RedirectValueTest()
        {
            // Arrange - создание контроллера
            ExampleController target = new ExampleController();

            // Act - вызов метода действия
            RedirectToRouteResult result = target.Redirect();

            // Assert - проверка результата
            Assert.IsFalse(result.Permanent);
            Assert.AreEqual("Example", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("MyID", result.RouteValues["ID"]);
        }
    }
}