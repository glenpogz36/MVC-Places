using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlaceList.Controllers;
using PlaceList.Models;
using System;

namespace PlaceList.Tests
{
    [TestClass]
    public class PlacesControllerTest
    {

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            PlacesController controller = new PlacesController();

            //Act
            ActionResult view = controller.Create("Seattle");

            //Assert
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectAction_Index()
        {
            //Arrange
            PlacesController controller = new PlacesController();
            RedirectToActionResult actionResult = controller.Create("Seattle") as RedirectToActionResult;

            //Act
            string result = actionResult.ActionName;

            //Assert
            Assert.AreEqual(result, "Index");
        }
    }
}