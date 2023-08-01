using CountryInfo.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CountryInfo.WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Страны
        /// </summary>
        public DbSet<Country> Countries { get; set; }

        /// <summary>
        /// Штаты/Регионы
        /// </summary>
        public DbSet<State> States { get; set; }

        /// <summary>
        /// Города
        /// </summary>
        public DbSet<City> Cities { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            // Создание базы данных, если её нет
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
