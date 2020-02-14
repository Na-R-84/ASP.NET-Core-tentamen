﻿using Colonize.Website.Data.Entities;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<CategoryProduct>().HasKey(pt => new
            {
                pt.ProductId,
                pt.CategoryId
            });
        }
    }
}

