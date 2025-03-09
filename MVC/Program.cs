using Microsoft.EntityFrameworkCore;
using MVC.Data;
using Microsoft.Extensions.DependencyInjection;

namespace MVC.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MyAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyAppContext") ?? throw new InvalidOperationException("Connection string 'MyAppContext' not found.")));

            // Add services to the container.
            var con = builder.Configuration.GetConnectionString("con");
            builder.Services.AddDbContext<HrAppdbContext>(options => options.UseSqlServer(con));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employee}/{action=Index}/{id?}");

            app.Run();
        }
    }
}