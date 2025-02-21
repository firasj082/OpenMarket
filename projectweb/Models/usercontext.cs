using Microsoft.EntityFrameworkCore;
using projectweb.Models;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace userList.Models
{

    public class usercontext : DbContext
    {

        public usercontext(DbContextOptions<usercontext> options)
               : base(options)
        { }
        public DbSet<user> users { get; set; } = null!;
        public DbSet<product> products { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<product>().HasData(
                new product { productid = 1, productname = "car bm2",Location="China",Company="AhmadTechnology", userid =1,Description = "Test", Price=100},
                new product { productid = 2, productname = "Comedy", Location = "China", Company = "AhmadTechnology", userid = 1, Description = "Test", Price = 100 },
                new product { productid = 3, productname = "Drama", Location = "China", Company = "AhmadTechnology", userid = 1, Price = 100 },
                new product { productid = 4, productname = "Horror", Location = "China", Company = "AhmadTechnology", userid = 1, Description = "Test", Price = 100 },
                new product { productid = 5, productname = "Musical", Location = "China", Company = "AhmadTechnology", userid = 1, Description = "Test", Price = 100 },
                new product { productid = 6, productname = "RomCom", Location = "China", Company = "AhmadTechnology", userid = 1, Description = "Test", Price = 100 },
                new product { productid = 7, productname = "SciFi", Location = "China", Company = "AhmadTechnology", userid = 1,Description="Test", Price = 100 }
            );
            modelBuilder.Entity<user>().HasData(
                new user
                {
                    userid = 1,
                    Username = "ahmad",
                    Phone = "056444322",
                    Email = "ahmadabualrob@gmail.com",
                    Ccnum = "11234",
                    Password = "11"
                }
                );
        }
       
    }
}
