using CodeAlongGr9.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeAlongGr9.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Car>().HasData(new Car { RegNumber = "ABC-123", Brand = "Volvo", CarModel = "V70" });
            modelbuilder.Entity<Car>().HasData(new Car { RegNumber = "DEF-456", Brand = "SAAB", CarModel = "93" });
            modelbuilder.Entity<Car>().HasData(new Car { RegNumber = "GHI-789", Brand = "BMW", CarModel = "E93" });

            modelbuilder.Entity<Person>().HasData(new Person { SSN = "880216", Name = "Jonathan Krall", City = "Stenstorp" });
            modelbuilder.Entity<Person>().HasData(new Person { SSN = "920202", Name = "Anders Andersson", City = "Anderstorp" });
            modelbuilder.Entity<Person>().HasData(new Person { SSN = "870328", Name = "Anna Svensson", City = "Stockholm" });


            modelbuilder.Entity<Person>()
                 .HasMany(p => p.Cars)
                 .WithMany(c => c.People)
                 .UsingEntity(j => j.HasData(new { PeopleSSN = "880216", CarsRegNumber = "ABC-123" }));
        
        }

    }
}
