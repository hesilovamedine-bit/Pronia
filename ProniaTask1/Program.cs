using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProniaTask1.DAL;

namespace ProniaTask1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options=>
            {
                options.UseSqlServer("Server=localhost;Database=ProniaDb;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false");
            });

            var app = builder.Build();


            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}
