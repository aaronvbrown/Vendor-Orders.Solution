using Microsoft.AspNetCore.Mvc;

namespace VendorOrders.Controllers
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