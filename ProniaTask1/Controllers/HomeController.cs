using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaTask1.DAL;
using ProniaTask1.Models;
using ProniaTask1.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace ProniaTask1.Controllers
{
    public class HomeController : Controller
    {


        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        //private List<Blog> blogs= new List<Blog>

        public async Task<IActionResult> Index()
        {
            //List<Slide> slides = new List<Slide>()
            //{
            //    new Slide
            //    {
            //         Title="Title1",
            //         Discount=29,
            //         Description="Lorem ipsum dolar",
            //         Order=3,
            //         Image="1-2-524x617.png"

            //    },
            //    new Slide
            //    {
            //         Title="Title2",
            //         Discount=20,
            //         Description="Lorem ipsum dolar",
            //         Order=1,
            //         Image="1-5-270x300.jpg"

            //    },
            //    new Slide
            //    {
            //         Title="Title3",
            //         Discount=12,
            //         Description="Lorem ipsum dolar",
            //         Order=2,
            //         Image="1-1-524x617.png"

            //    }

            //};
            //List<Blog> blogs = new List<Blog>()
            //{
            //    new Blog
            //    {
            //         Title="Title1",
            //         Discount=29,
            //         Description="Lorem ipsum dolar",
            //         Order=3,
            //         Image="1-2-524x617.png"

            //    },
            //    new Blog
            //    {
            //         Title="Title2",
            //         Discount=20,
            //         Description="Lorem ipsum dolar",
            //         Order=1,
            //         Image="1-5-270x300.jpg"

            //    },
            //    new Blog
            //    {
            //         Title="Title3",
            //         Discount=12,
            //         Description="Lorem ipsum dolar",
            //         Order=2,
            //         Image="1-1-524x617.png"

            //    }

            //};
            ////////////////////////////////////////////////
            ////////////////////////////////////////////////
            

            //_context.Sliders.AddRange(slides);
            //_context.SaveChanges();




            HomeVM homeVM = new HomeVM
            {
                Slides = await  _context.Sliders.OrderBy(s=>s.Order).ToListAsync(),
                Blogs = await   _context.Blogs.OrderBy(b=>b.Order).ToListAsync(),
            };
           
            return View(homeVM);
        }


        public IActionResult Details()
        {
            return View();
        }


        public IActionResult NotFound()
        {
            return View();
        }


    }
}
