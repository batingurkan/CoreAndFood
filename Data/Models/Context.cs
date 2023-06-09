﻿using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("server=BATIN-PC\\SQLEXPRESS; database=DbCoreFood; integrated security=true");

        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
