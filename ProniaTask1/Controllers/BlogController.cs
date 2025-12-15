using Microsoft.AspNetCore.Mvc;

namespace ProniaTask1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
