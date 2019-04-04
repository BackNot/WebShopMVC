using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Models;
using System.Data.Entity;

namespace WebShop.Context
{
    public class CustInit : CreateDatabaseIfNotExists<WebShopDb>
    {
        protected override void Seed(WebShopDb context)
        { // so we always have admin account with username 'root' and pw 'root'.
           // It is lame , but it is for test environment/project.

           
            Administrator root = new Administrator();
            root.Username="root";
            root.Password="root";
            context.Administrators.Add(root);

            // Items

            IList<Item> items = new List<Item>();
            // Men Shirts
            items.Add(new Item() { Name = "Black T-Shirt", Description = "Shirt", AdditionalInformation = "--", Price = Convert.ToDecimal("21.00"), Size = "M", Image = "Images/MenShirt1.jpg" });
            items.Add(new Item() { Name = "Black T-Shirt #2", Description = "Shirt", AdditionalInformation = "--", Price = Convert.ToDecimal("25.00"), Size = "XL,L", Image = "Images/MenShirt2.jpg" });
            items.Add(new Item() { Name = "Under armour", Description = "Shirt", AdditionalInformation = "--", Price = Convert.ToDecimal("30.00"), Size = "XS,S,M,XL", Image = "Images/MenShirt3.jpg" });
            items.Add(new Item() { Name = "Stylish T-Shirt", Description = "Shirt", AdditionalInformation = "100% Cotton", Price = Convert.ToDecimal("30.00"), Size = "S,M,L", Image = "Images/MenShirt4.jpg" });
            items.Add(new Item() { Name = "T-Shirt", Description = "Shirt", AdditionalInformation = "--", Price = Convert.ToDecimal("20.00"), Size = "M,L", Image = "Images/MenShirt5.jpg" });
            items.Add(new Item() { Name = "Black-Red T-Shirt", Description = "Shirt", AdditionalInformation = "100% Cotton", Price = Convert.ToDecimal("25.00"), Size = "XS,S,M,L,XL,XXL", Image = "Images/MenShirt6.jpg" });
            items.Add(new Item() { Name = "Black-Blue T-Shirt", Description = "Shirt", AdditionalInformation = "100% Cotton", Price = Convert.ToDecimal("20.00"), Size = "M,L", Image = "Images/MenShirt7.jpg" });
            items.Add(new Item() { Name = "Breaking Bad", Description = "Shirt", AdditionalInformation = "--", Price = Convert.ToDecimal("25.00"), Size = "S,M,L,XL", Image = "Images/MenShirt8.jpg" });
            items.Add(new Item() { Name = "Blue T-Shirt", Description = "Shirt", AdditionalInformation = "100% Cotton", Price = Convert.ToDecimal("20.00"), Size = "M,XL", Image = "Images/MenShirt9.jpg" });
            items.Add(new Item() { Name = "Black-White T-Shirt", Description = "Shirt", AdditionalInformation = "100% Cotton", Price = Convert.ToDecimal("20.00"), Size = "XS,L,XXL", Image = "Images/MenShirt10.jpg" });
            // Men Jackets
            items.Add(new Item() { Name = "Leather Jacket", Description = "Jacket", AdditionalInformation = "100% Leather", Price = Convert.ToDecimal("75.00"), Size = "M,L,XL", Image = "Images/MenJacket1.jpg" });
            items.Add(new Item() { Name = "Style Jacket", Description = "Jacket", AdditionalInformation = "Perfect for autumn", Price = Convert.ToDecimal("50.00"), Size = "M,L,XL", Image = "Images/MenJacket2.jpg" });
            items.Add(new Item() { Name = "Two-faced Jacket", Description = "Jacket", AdditionalInformation = "--", Price = Convert.ToDecimal("69.00"), Size = "L,XL", Image = "Images/MenJacket3.jpg" });
            items.Add(new Item() { Name = "Leather Jacket", Description = "Jacket", AdditionalInformation = "Brown jacket 100% leather", Price = Convert.ToDecimal("81.00"), Size = "S,M,L", Image = "Images/MenJacket4.jpg" });
            items.Add(new Item() { Name = "Long Jacket", Description = "Jacket", AdditionalInformation = "--", Price = Convert.ToDecimal("80.00"), Size = "M,L,XL", Image = "Images/MenJacket4.jpg" });
            items.Add(new Item() { Name = "Stylish Jacket", Description = "Jacket", AdditionalInformation = "--", Price = Convert.ToDecimal("90.00"), Size = "L", Image = "Images/MenJacket5.jpg" });
          // Women Dresses
            items.Add(new Item() { Name = "Blue Dress", Description = "Dress", AdditionalInformation = "--", Price = Convert.ToDecimal("60.00"), Size = "S,M,L", Image = "Images/WomenDress1.jpg" });
            items.Add(new Item() { Name = "Black Dress", Description = "Dress", AdditionalInformation = "--", Price = Convert.ToDecimal("65.00"), Size = "S,M,L,XL", Image = "Images/WomenDress2.jpg" });
            items.Add(new Item() { Name = "Short Dress", Description = "Dress", AdditionalInformation = "--", Price = Convert.ToDecimal("60.00"), Size = "S,M", Image = "Images/WomenDress3.jpg" });
            items.Add(new Item() { Name = "Long Dress", Description = "Dress", AdditionalInformation = "Long black dress", Price = Convert.ToDecimal("75.00"), Size = "XS,S,M,L,XL", Image = "Images/WomenDress4.jpg" });
            items.Add(new Item() { Name = "Stylish Dress", Description = "Dress", AdditionalInformation = "--", Price = Convert.ToDecimal("100.00"), Size = "S,M", Image = "Images/WomenDress5.jpg" });
            items.Add(new Item() { Name = "Stylish Dress", Description = "Dress", AdditionalInformation = "Bonus: purse", Price = Convert.ToDecimal("150.00"), Size = "XS,S,M", Image = "Images/WomenDress6.jpg" });
            items.Add(new Item() { Name = "Stylish Dress", Description = "Dress", AdditionalInformation = "--", Price = Convert.ToDecimal("75.00"), Size = "XS,S,L", Image = "Images/WomenDress7.jpg" });
            items.Add(new Item() { Name = "Stylish dress", Description = "Dress", AdditionalInformation = "Black dress with roses", Price = Convert.ToDecimal("90.00"), Size = "S,M,L", Image = "Images/WomenDress8.jpg" });
            items.Add(new Item() { Name = "Long Dress", Description = "Dress", AdditionalInformation = "Black with white", Price = Convert.ToDecimal("95.00"), Size = "M,L", Image = "Images/WomenDress10.jpg" });
            items.Add(new Item() { Name = "Long Dress", Description = "Dress", AdditionalInformation = "Black with flowers", Price = Convert.ToDecimal("100.00"), Size = "S,M,L", Image = "Images/WomenDress11.jpg" });
            items.Add(new Item() { Name = "Official Dress", Description = "Dress", AdditionalInformation = "Grey", Price = Convert.ToDecimal("80.00"), Size = "XS,S,M", Image = "Images/WomenDress12.jpg" });
            items.Add(new Item() { Name = "Official Dress", Description = "Dress", AdditionalInformation = "--", Price = Convert.ToDecimal("60.00"), Size = "XS,S,M,L", Image = "Images/WomenDress13.jpg" });
            // Women Jeans
            items.Add(new Item() { Name = "Blue Jeans #1", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("30.00"), Size = "XS,S,M,L,XL", Image = "Images/WomenJeans1.jpg" });
            items.Add(new Item() { Name = "Light-Blue Jeans", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("35.00"), Size = "XS,S,M", Image = "Images/WomenJeans2.jpg" });
            items.Add(new Item() { Name = "Dark-Blue Jeans", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("40.00"), Size = "M", Image = "Images/WomenJeans3.jpg" });
            items.Add(new Item() { Name = "Light Jeans", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("30.00"), Size = "S,M,L", Image = "Images/WomenJeans4.jpg" });
            items.Add(new Item() { Name = "Dark Jeans", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("30.00"), Size = "S,M,L", Image = "Images/WomenJeans5.jpg" });
            items.Add(new Item() { Name = "Dark Jeans", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("25.00"), Size = "M", Image = "Images/WomenJeans6.jpg" });
            items.Add(new Item() { Name = "Cool Jeans", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("35.00"), Size = "XS,S,M", Image = "Images/WomenJeans8.jpg" });
            items.Add(new Item() { Name = "Green Jeans", Description = "Jeans", AdditionalInformation = "--", Price = Convert.ToDecimal("30.00"), Size = "S,M", Image = "Images/WomenJeans9.jpg" });

            context.Items.AddRange(items);
            base.Seed(context);
        }
    }
}