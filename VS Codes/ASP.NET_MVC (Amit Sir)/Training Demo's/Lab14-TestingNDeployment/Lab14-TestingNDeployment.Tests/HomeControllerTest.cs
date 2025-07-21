using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab14_TestingNDeployment.Controllers;
using System.Web.Mvc;

namespace Lab14_TestingNDeployment.Tests
{
    [TestClass] 
    public class HomeControllerTest
    {
        //Checks Action Returns a CorrectView
        [TestMethod]
        public void IndexActionReturnsHomePageView()
        {
            // Arrange
            var homeController = new HomeController();
            // Act
            var result = homeController.Index() as ViewResult;
            // Assert
            Assert.AreEqual("HomePage", result.ViewName);
        }

        //Checks ViewBag returns same message 
        [TestMethod]
        public void AboutActionPassesViewBag()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.AreEqual("About Us", result.ViewBag.Message);
        }

        //Checks ViewBag returns some value 
        [TestMethod]
        public void AboutActioViewBagReturnsSomeValue()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.IsNotNull(result.ViewBag.Message);
        }

        //Checks action method returns a result
        [TestMethod]
        public void ViewMapsRetursResult()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.ViewMaps() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
