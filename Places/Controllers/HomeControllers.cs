using Microsoft.AspNetCore.Mvc;

namespace PlaceList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}