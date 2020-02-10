using Microsoft.EntityFrameworkCore;
using MyFirstWebAPIExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPIExample.Providers
{
    public class MenuCategoryDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=LAPTOP-JTFGLLBJ\SQLEXPRESS;initial catalog=[ELITE_RESTAURANT];integrated security=True;MultipleActiveResultSets=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuCategoryMapping());
        }
        public DbSet<MenuCategory> menuCategories { get; set; }
    }
      
}
