using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Infrastructure.DbContext
{
    public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<User, UserRole, Guid>(options)
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<OrderItem>().ToTable("OrderItems");

            var products = ReadUsersFromCsv("E:\\Dev\\AspNetCore\\PracticeProjectSolution\\PracticeProject.Infrastructure\\DbContext\\Data\\Products.csv");
            builder.Entity<Product>().HasData(products);

            var roles = new List<UserRole>
            {
                new() { Id = Guid.NewGuid(), Name= "User", NormalizedName = "USER"},
                new() { Id = Guid.NewGuid(), Name= "Admin", NormalizedName = "ADMIN"}
            };
            builder.Entity<UserRole>().HasData(roles);
        }

        private List<Product> ReadUsersFromCsv(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
            return csv.GetRecords<Product>().ToList();
        }
    }
}
