using Microsoft.EntityFrameworkCore;
using ProniaTask1.Models;

namespace ProniaTask1.DAL
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Slide> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }

}


