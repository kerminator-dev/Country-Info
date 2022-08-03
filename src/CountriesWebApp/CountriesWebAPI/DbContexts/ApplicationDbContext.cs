using CountriesWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CountriesWebAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            base.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(c => c.States)
                .WithOne();

            modelBuilder.Entity<State>()
                .HasMany(s => s.Cities)
                .WithOne();
        }
    }
}
