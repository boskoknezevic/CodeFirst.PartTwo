using CodeFirst.PartTwo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }

        public CarContext() { }

        public CarContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
               // @"Data Source=BKNEZEVIC-INT;Database=CodeFirst.PartTwo;Integrated Security=False;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User=sa;Password=565884;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, Color = "Blue", Year = 2001, ChassisNumber = 1234, Brand = "Fiat", Model = "Punto" },
                new Car { CarId = 2, Color = "Red", Year = 2005, ChassisNumber = 4567, Brand = "Volkswagen", Model = "Passat" },
                new Car { CarId = 3, Color = "Yellow", Year = 2012, ChassisNumber = 9900, Brand = "Renault", Model = "Scenic" }
                );

            modelBuilder.Entity<Engine>().HasData(
                new Engine { EngineId = 1, Year = 2001, Brand = "Fiat", SerialNumber = "000000", Type = "type1", CarId = 1, EngineTypeId = 1 },
                new Engine { EngineId = 2, Year = 2005, Brand = "Volkswagen", SerialNumber = "000001", Type = "type2", CarId = 2, EngineTypeId = 1 },
                new Engine { EngineId = 3, Year = 2012, Brand = "Renault", SerialNumber = "000002", Type = "type3", CarId = 3, EngineTypeId = 2 }
                );

            modelBuilder.Entity<EngineType>().HasData(
                new EngineType { EngineTypeId = 1, Model = "Model1", Name = "Name1" },
                new EngineType { EngineTypeId = 2, Model = "Model2", Name = "Name2" }
                );

        }
    }
}
