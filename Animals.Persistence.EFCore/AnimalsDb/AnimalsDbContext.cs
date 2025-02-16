using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Animals.Persistence.EFCore.AnimalsDbContext
{
    internal class AnimalsDbContext(DbContextOptions<AnimalsDbContext> options): DbContext
    {
        public static string AnimalsDbSchema = "animals";
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
