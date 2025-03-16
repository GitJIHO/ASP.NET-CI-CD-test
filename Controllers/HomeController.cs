using Microsoft.AspNetCore.Mvc;

namespace Testapi.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("ohohoh");
        }

        [HttpGet("oh")]
        public IActionResult About()
        {
            return Content("yee");
        }
    }
}