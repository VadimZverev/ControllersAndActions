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
        public void ViewSelectionTest()
        {
            // Arrange - создание контроллера
            ExampleController target = new ExampleController();

            // Act - вызов метода действия
            ViewResult result = target.Index();

            // Assert - проверка результата
            Assert.AreEqual("Hello, World", result.ViewData.Model);
        }

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
        public void RedirectTest()
        {
            // Arrange - создание контроллера
            ExampleController target = new ExampleController();

            // Act - вызов метода действия
            RedirectResult result = target.Redirect();

            // Assert - проверка результата
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("/Example/Index", result.Url);
        }
    }
}