using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaceList.Models;

namespace PlaceList.Tests
{
  [TestClass]
  public class PlaceTest
  {
    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string cityName = "Seattle";
      Place newPlace = new Place(cityName);

      //Act
      int result = newPlace.GetId();

      //Assert
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      //Arrange
      string cityName1 = "Seattle";
      string cityName2 = "Epicodus";
      Place newPlace1 = new Place(cityName1);
      Place newPlace2 = new Place(cityName2);

      //Act
      Place result = Place.Find(5);

      //Assert
      Assert.AreEqual(newPlace2, result);
    }

  }
}
