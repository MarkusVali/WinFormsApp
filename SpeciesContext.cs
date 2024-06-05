using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class SpeciesContext : DbContext
    {
        public DbSet<Species> Speciess { get; set; }
        public DbSet<FursonaType> FursonaTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FursonaType>().HasData(
                new FursonaType { FursonaTypeId = 1, FursonaTypeName = "Furry" },
                new FursonaType { FursonaTypeId = 2, FursonaTypeName = "Scalie" },
                new FursonaType { FursonaTypeId = 3, FursonaTypeName = "Avian" },
                new FursonaType { FursonaTypeId = 4, FursonaTypeName = "Special" });

            modelBuilder.Entity<Species>().HasData(
                new Species { SpeciesId = 1, FursonaTypeId = 1, SpeciesName = "Fox" },
                new Species { SpeciesId = 2, FursonaTypeId = 1, SpeciesName = "Wolf" },
                new Species { SpeciesId = 3, FursonaTypeId = 1, SpeciesName = "Dog" },
                new Species { SpeciesId = 4, FursonaTypeId = 1, SpeciesName = "Cat" },
                new Species { SpeciesId = 5, FursonaTypeId = 1, SpeciesName = "Fold" },
                new Species { SpeciesId = 6, FursonaTypeId = 2, SpeciesName = "Shark" },
                new Species { SpeciesId = 7, FursonaTypeId = 2, SpeciesName = "Orca" },
                new Species { SpeciesId = 8, FursonaTypeId = 2, SpeciesName = "Snake" },
                new Species { SpeciesId = 9, FursonaTypeId = 3, SpeciesName = "Peacock" },
                new Species { SpeciesId = 10, FursonaTypeId = 3, SpeciesName = "Chicken" },
                new Species { SpeciesId = 11, FursonaTypeId = 3, SpeciesName = "Blue jay" },
                new Species { SpeciesId = 12, FursonaTypeId = 4, SpeciesName = "Protogen" },
                new Species { SpeciesId = 13, FursonaTypeId = 4, SpeciesName = "Zetagen" },
                new Species { SpeciesId = 14, FursonaTypeId = 4, SpeciesName = "Primagen" },
                new Species { SpeciesId = 15, FursonaTypeId = 4, SpeciesName = "Hybrid" });
        }
    }
}
