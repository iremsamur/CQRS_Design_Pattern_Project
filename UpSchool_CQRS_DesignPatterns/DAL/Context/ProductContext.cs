using Microsoft.EntityFrameworkCore;
using UpSchool_CQRS_DesignPatterns.DAL.Entities;

namespace UpSchool_CQRS_DesignPatterns.DAL.Context
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-ISO96UVH\\SQLEXPRESS;Database=UpSchoolCQRS;integrated security=True;");//DataSource='de kullanılabilir.


        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }


    }
}
