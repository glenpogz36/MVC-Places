using Microsoft.AspNetCore.Mvc;
using PlaceList.Models;
using System.Collections.Generic;

namespace PlaceList.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }


    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string description, string picture)
    {
      Place newPlace = new Place(cityName, description, picture);
      return RedirectToAction("Index");
    }

    [HttpGet("places/{id}")]
    public ActionResult Show(int id)
    {
      Place place = Place.Find(id);
      return View(place);
    }


    [HttpPost("places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

  }
}