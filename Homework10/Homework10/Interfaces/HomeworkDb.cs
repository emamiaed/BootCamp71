using Homework10.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework10.Interfaces
{
    public class HomeworkDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Initial Catalog=HomeworkDb;TrustServerCertificate=True;Password=123abc;User ID=sa;Data Source=.\bootcamp");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<City> Cities { get; set; }
     //  public DbSet<Gender> Genders { get; set; }
        public DbSet<Library> Libraries { get; set; }
      //  public DbSet<MemberShipType> MemberShipTypes { get; set; }


    }
}
