using Microsoft.AspNetCore.Mvc;

namespace URLShipping.Controllers
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