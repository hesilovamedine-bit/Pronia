using Microsoft.AspNetCore.Mvc;
using ProniaTask1.Models;
using ProniaTask1.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace ProniaTask1.Controllers
{
    public class HomeController : Controller
    {
        private List<Blog> blogs;

        public IActionResult Index()
        {
            List<Slide> slides = new List<Slide>()
            {
                new Slide
                {
                     Id=1,
                     Title="Title1",
                     Discount=29,
                     Description="Lorem ipsum dolar",
                     Order=3,
                     Image="1-2-524x617.png"

                },
                new Slide
                {
                     Id=2,
                     Title="Title2",
                     Discount=20,
                     Description="Lorem ipsum dolar",
                     Order=1,
                     Image="1-5-270x300.jpg"

                },
                new Slide
                {
                     Id=3,
                     Title="Title3",
                     Discount=12,
                     Description="Lorem ipsum dolar",
                     Order=2,
                     Image="1-1-524x617.png"

                }

            };
            List<Blog> blogs = new List<Blog>()
            {
                new Blog
                {
                     Id=1,
                     Title="Title1",
                     Discount=29,
                     Description="Lorem ipsum dolar",
                     Order=3,
                     Image="1-2-524x617.png"

                },
                new Blog
                {
                     Id=2,
                     Title="Title2",
                     Discount=20,
                     Description="Lorem ipsum dolar",
                     Order=1,
                     Image="1-5-270x300.jpg"

                },
                new Blog
                {
                     Id=3,
                     Title="Title3",
                     Discount=12,
                     Description="Lorem ipsum dolar",
                     Order=2,
                     Image="1-1-524x617.png"

                }

            };

            HomeVM homeVM = new HomeVM
            {
                Slides = slides.OrderBy(s => s.Order).Take(2).ToList(),
                Blogs = blogs.OrderBy(b => b.Order).Take(2).ToList(),
            };
           
            return View(homeVM);
        }






        public IActionResult NotFound()
        {
            return View();
        }


    }
}
