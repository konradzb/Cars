using Cars.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

// to create new migration
// create variable with new model e.g. "public virtual DbSet<Brand> Brands { get; set; }"
// in console type "add-migration <name_of_migration>"
// to update the database type "update-database" and it will use the latest migration
namespace Cars.Configuration
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<CarRental> CarRentals { get; set; }
        public virtual DbSet<Model.Model> Model { get; set; }
        public virtual DbSet<CarDrive> CarDrive { get; set; }
        public virtual DbSet<FuelType> FuelType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("Server=dot-cars.mysql.database.azure.com; Port=3306; Database=cars; User=system@dot-cars; Password=i7!3$uRmGtY&t#fjMgTr;",
                new MySqlServerVersion(new Version(8, 0, 11)))
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}