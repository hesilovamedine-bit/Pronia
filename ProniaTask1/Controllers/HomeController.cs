using Microsoft.AspNetCore.Mvc;

namespace ProniaTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NotFound()
        {
            return View();
        }


    }
}
