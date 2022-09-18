using Microsoft.EntityFrameworkCore;
using SportLane.Ecommerce.API.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace SportLane.Ecommerce.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<ProductCategory> ProductsCategories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>().Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Address>().Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Customer>().Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>().Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ProductCategory>().HasKey(p => new { p.ProductId, p.CategoryId });
            modelBuilder.Entity<OrderItems>().HasKey(o => new { o.OrderId, o.ProductId });
        }
    }
}
