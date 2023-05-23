using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAPP.DDD.Domain.Entities;

namespace ProductAPP.DDD.Infraestructure
{
    public class DatabaseContext :IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options ):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>(e =>
            {
                e.HasKey(a=>a.Id);
            });
            builder.Entity<Product>().Property(e=>e.Id).ValueGeneratedOnAdd();
            builder.Entity<Product>().OwnsOne(e => e.Name, config =>
            {
                config.Property(p => p.Value).HasColumnName("Name");
            });
            builder.Entity<Product>().OwnsOne(e=>e.Price,config => {
                config.Property(a =>a.Value).HasColumnName("Price").HasPrecision(18,2);
            });
            builder.Entity<Product>().OwnsOne(e=>e.Stock,config =>
            {
                config.Property(p => p.Value).HasColumnName("Stock");
            });
            builder.Entity<Product>().OwnsOne(e=>e.Description,config =>
            {
                config.Property(p=>p.Value).HasColumnName("Description").HasMaxLength(400);
            });
            base.OnModelCreating(builder);
           
        }
        public DbSet<Product> Products { get; set; }
    }
}
