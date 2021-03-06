﻿using EFCoreSeedMigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSeedMigrations.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
            : base(options)
        {
        }
    }
}