using Exam2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam2.Interfaces
{
    public class ProductDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Initial Catalog=ProductDbContext;TrustServerCertificate=True;Password=123abc;User ID=sa;Data Source=.\bootcamp");

        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
