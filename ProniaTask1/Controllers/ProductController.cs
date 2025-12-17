using Microsoft.AspNetCore.Mvc;

namespace ProniaTask1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
