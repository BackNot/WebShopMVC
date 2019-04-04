using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebShop.Models;

namespace WebShop.Context
{
    public class WebShopDb : DbContext
    {
         public WebShopDb(): base("WebShopDb") 
        {
        Database.SetInitializer(new CustInit());
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Purchase> Purchases { get; set; }


    }
}