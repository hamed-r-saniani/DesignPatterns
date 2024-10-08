﻿using Menu_Category_Sample.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Menu_Category_Sample.Models.Contexts
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=CompositeDbAsp;Integrated Security=True;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CategoryComponent> CategoryComponents { get; set; }
        private DbSet<Category> Categories { get; set; }
        private DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
