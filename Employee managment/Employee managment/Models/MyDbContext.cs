using Employee_managment.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace Employee_managment.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}
