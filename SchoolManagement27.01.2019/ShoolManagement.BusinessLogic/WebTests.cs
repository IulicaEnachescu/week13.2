using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SchoolManagement;
using SchoolManagement.Controllers;
using System.Web.Mvc;

namespace ShoolManagement.BusinessLogic
{
    [TestFixture]
    public class WebTests
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Contact() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
