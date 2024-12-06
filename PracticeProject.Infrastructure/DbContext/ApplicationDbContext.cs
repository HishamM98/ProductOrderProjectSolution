using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Infrastructure.DbContext
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Product> Products { get; set; } 
        public virtual DbSet<Order> Orders { get; set; } 
        public virtual DbSet<OrderItem> OrderItems { get; set; }

        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<OrderItem>().ToTable("OrderItems");
        }
    }
}
