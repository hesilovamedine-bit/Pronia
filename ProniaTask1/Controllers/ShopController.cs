using Microsoft.AspNetCore.Mvc;

namespace ProniaTask1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
