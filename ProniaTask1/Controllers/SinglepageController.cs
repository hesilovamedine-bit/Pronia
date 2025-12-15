using Microsoft.AspNetCore.Mvc;

namespace ProniaTask1.Controllers
{
    public class SinglepageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
