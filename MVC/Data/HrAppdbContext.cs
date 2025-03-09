using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class HrAppdbContext : DbContext
    {
        public HrAppdbContext(DbContextOptions<HrAppdbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
