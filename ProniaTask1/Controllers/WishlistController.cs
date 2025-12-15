using Microsoft.AspNetCore.Mvc;

namespace ProniaTask1.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
