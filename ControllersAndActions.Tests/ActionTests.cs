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
    }
}