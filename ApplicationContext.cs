using Microsoft.EntityFrameworkCore;
using TBPP_LABS.Models;

namespace TBPP_LABS
{

    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons => Set<Person>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
