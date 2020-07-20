using Microsoft.AspNetCore.Mvc;

namespace ToDos.Controllers
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