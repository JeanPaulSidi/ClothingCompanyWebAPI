using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClothingCompanyWebAPI.Models;

namespace ClothingCompanyWebAPI.Data
{
    public class ClothingCompanyWebAPIContext : DbContext
    {
        public ClothingCompanyWebAPIContext (DbContextOptions<ClothingCompanyWebAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer 
                {
                    CustomerId = 1,
                    CustomerFirstName = "Jean Paul",
                    CustomerLastName = "Sidi",
                    CustomerBirthDate = DateTime.Now,
                    CustomerEmail = "jps@gmail.com",
                    CustomerPhoneNumber = "123 456 7890",
                    CustomerAddress = "23 Jk Hwy",
                    CustomerCity = "Chehalis",
                    CustomerState = "WA",
                    CustomerZipCode = "12345"
                },

                new Customer 
                {
                    CustomerId = 2,
                    CustomerFirstName = "Kerly",
                    CustomerLastName = "Image",
                    CustomerBirthDate = DateTime.Now,
                    CustomerEmail = "kerly@gmail.com",
                    CustomerPhoneNumber = "360 444 2345",
                    CustomerAddress = "45 K Street",
                    CustomerCity = "Centralia",
                    CustomerState = "OR",
                    CustomerZipCode= "00345"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product 
                {
                    ProductId = 1,
                    ProductName = "Shirt",
                    ProductPrice = 20M,
                    ProductDescription = "Nice men shirt..."
                },

                new Product 
                {
                    ProductId = 2,
                    ProductName = "Coat",
                    ProductPrice = 65M,
                    ProductDescription = "Nice women winter coat..."
                },

                new Product 
                {
                    ProductId = 3,
                    ProductName = "Trousers",
                    ProductPrice = 34M,
                    ProductDescription = "Nice Trousers for men..."
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order 
                {
                    OrderId = 1,
                    OrderDate = DateTime.Now,
                    OrderTotalAmount = 125M
                },

                new Order 
                {
                    OrderId = 2,
                    OrderDate = DateTime.Now,
                    OrderTotalAmount = 68M
                }
            );

            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct 
                {
                    OrderProductId = 1,
                    OrderId = 1,
                    ProductId = 1,
                    QuantityProductOrdered = 3
                },

                new OrderProduct 
                {
                    OrderProductId= 2,
                    OrderId = 2,
                    ProductId = 3,
                    QuantityProductOrdered = 2 
                },

                new OrderProduct 
                {
                    OrderProductId= 3,
                    OrderId = 1,
                    ProductId = 2,
                    QuantityProductOrdered = 1
                }
            );
        }

        public DbSet<ClothingCompanyWebAPI.Models.Customer> Customer { get; set; } = default!;
        public DbSet<ClothingCompanyWebAPI.Models.Order> Order { get; set; } = default!;
        public DbSet<ClothingCompanyWebAPI.Models.Product> Product { get; set; } = default!;
    }
}
