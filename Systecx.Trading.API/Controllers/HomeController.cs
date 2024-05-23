using Microsoft.AspNetCore.Mvc;

namespace Systecx.Trading.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
