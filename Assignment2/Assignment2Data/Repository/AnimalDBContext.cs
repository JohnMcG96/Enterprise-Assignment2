using System;
using System.Collections.Generic;
using System.Text;
using Assignment2Data.Animal;
using Microsoft.EntityFrameworkCore;

namespace Assignment2Data.Repository
{
    public class AnimalDBContext : DbContext
    {
        public AnimalDBContext()
        {
        }
        public AnimalDBContext(DbContextOptions<AnimalDBContext> options)
        : base(options)
        {
        }
        public DbSet<Animals> Animal { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Assignment2;Trusted_Connection = True;");
        }
        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }
}
