using System;
using Microsoft.EntityFrameworkCore;

namespace EFExample.DataModels
{
    public class Context: DbContext
    {
        // Cada DbSet representará una tabla en la bd
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=efexample;User=sa;Password=Chuyoso21");
        }
    }
}