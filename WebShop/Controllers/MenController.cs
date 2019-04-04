using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;
using WebShop.Context;
using PagedList;

namespace WebShop.Controllers
{
    public class MenController : Controller
    {
        WebShopDb context = new WebShopDb(); // make context
       

        public ActionResult Shirts(string sortOrder, int? page)
        {

            if ((page <= 0) || (page == null))
            {
                ViewBag.id = 1;
            }
            else
                ViewBag.id = page;

            ViewBag.CurrentSort = sortOrder; // sort of the list
            List<Item> items = new List<Item>();
            items = context.Items.ToList(); // make all items in the Db to list
            List<Item> toRender = new List<Item>();
            foreach (var item in items)
            { // Show only "Shirt" items
                if (item.Description.ToLower() == "shirt")
                {
                    toRender.Add(item);
                }
            }
            int pageSize = 8;
            int pageNumber = page ?? 1;
            switch (sortOrder)
            { // sort of the list
                case "high":
                    toRender = toRender.OrderByDescending(obj => obj.Price).ToList();
                    break;
                case "low":
                    toRender = toRender.OrderBy(obj => obj.Price).ToList();
                    break;
            }
            return View(toRender.ToPagedList(pageNumber, pageSize));
        }
        [HttpPost]
        public ActionResult Shirts(int id, string sortOrder, string submit, int? page)
        {
            string size = string.Empty;
            switch (submit)
            {
                case "XS": size = "XS";
                    break;
                case "S": size = "S";
                    break;
                case "M": size = "M";
                    break;
                case "L": size = "L";
                    break;
                case "XL": size = "XL";
                    break;
                case "XXL": size = "XS";
                    break;

                default:
                    throw new Exception();

            }

            HttpCookie cookie = Request.Cookies.Get("ShoppingCartId"); // get the user's cookie

            if (cookie == null) // if cookie is null initialize new cart => new client and purchase
            {
                Random rand = new Random();
                int random = rand.Next();
                string cookieValue = random.ToString();
                // ADD COOKIE 
                // every cookie is tied with long random generated number ( almost in every case its going to be unique)
                HttpCookie userIdCookie = new HttpCookie("ShoppingCartId");
                userIdCookie.Value = cookieValue;
                userIdCookie.Expires = DateTime.Now.AddDays(90);
                Response.SetCookie(userIdCookie);
                // END ADD COOKIE
                var itemInDb = context.Items.Find(id);  // find the item

                Cart cart = new Cart();
                cart.BoughtItems = new List<ItemAndSize>();
                ItemAndSize itemToBuy = new ItemAndSize(); // create new item for adding
                itemToBuy.Item = itemInDb.ItemId.ToString();

                itemToBuy.Sizes = size; // add it 

                cart.ShoppingCartId = cookieValue;
                cart.BoughtItems.Add(itemToBuy);
                cart.BoughtSizes = size;
                context.Carts.Add(cart);
                context.SaveChanges();
            }
            else
            {
                var getCart = (from obj in context.Carts //get the cart
                               where obj.ShoppingCartId == cookie.Value
                               select obj).FirstOrDefault();
                var itemInDb = context.Items.Find(id);  // find the item
                ItemAndSize itemToBuy = new ItemAndSize();
                itemToBuy.Item = itemInDb.ItemId.ToString();

                itemToBuy.Sizes = size;
                getCart.BoughtItems.Add(itemToBuy);

            }

            context.SaveChanges();


            if ((page <= 0) || (page == null))
            {
                ViewBag.id = 1;
            }
            else
                ViewBag.id = page;

            ViewBag.CurrentSort = sortOrder;
            List<Item> items = new List<Item>();
            items = context.Items.ToList();
            List<Item> toRender = new List<Item>();
            foreach (var item2 in items)
            {
                if (item2.Description.ToLower() == "shirt")
                {
                    toRender.Add(item2);
                }
            }
            int pageSize = 8;
            int pageNumber = page ?? 1;
            switch (sortOrder)
            {
                case "high":
                    toRender = toRender.OrderByDescending(obj => obj.Price).ToList();
                    break;
                case "low":
                    toRender = toRender.OrderBy(obj => obj.Price).ToList();
                    break;
            }
            return View(toRender.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Jackets(string sortOrder, int? page)
        {
             // Repeat the same process from shirts to jackets with minor changes
            if ((page <= 0) || (page == null))
            {
                ViewBag.id = 1;
            }
            else
                ViewBag.id = page;

            ViewBag.CurrentSort = sortOrder;
            List<Item> items = new List<Item>();
            items = context.Items.ToList();
            List<Item> toRender = new List<Item>();
            foreach (var item in items)
            {
                if (item.Description.ToLower() == "jacket")
                {
                    toRender.Add(item);
                }
            }
            int pageSize = 8;
            int pageNumber = page ?? 1;
            switch (sortOrder)
            {
                case "high":
                    toRender = toRender.OrderByDescending(obj => obj.Price).ToList();
                    break;
                case "low":
                    toRender = toRender.OrderBy(obj => obj.Price).ToList();
                    break;
            }
            return View(toRender.ToPagedList(pageNumber, pageSize));
        }
        [HttpPost]
        public ActionResult Jackets(int id, string sortOrder, string submit,int? page)
        {
            string size = string.Empty;
            switch (submit)
            {
                case "XS": size = "XS";
                    break;
                case "S": size = "S";
                    break;
                case "M": size = "M";
                    break;
                case "L": size = "L";
                    break;
                case "XL": size = "XL";
                    
                    break;
                case "XXL": size = "XS";
                    break;

                default:
                    throw new Exception();

            }

            HttpCookie cookie = Request.Cookies.Get("ShoppingCartId");

            if (cookie == null) // if cookie is null initialize new cart
            {
                Random rand = new Random();
                int random = rand.Next();
                string cookieValue = random.ToString();
                // ADD COOKIE
                HttpCookie userIdCookie = new HttpCookie("ShoppingCartId");
                userIdCookie.Value = cookieValue;
                userIdCookie.Expires = DateTime.Now.AddDays(90);
                Response.SetCookie(userIdCookie);
                // END ADD COOKIE
                var itemInDb = context.Items.Find(id);  // find the item

                Cart cart = new Cart();
                cart.BoughtItems = new List<ItemAndSize>();
                ItemAndSize itemToBuy = new ItemAndSize(); // create new item for adding
                itemToBuy.Item = itemInDb.ItemId.ToString();

                itemToBuy.Sizes = size; // add it 

                cart.ShoppingCartId = cookieValue;
                cart.BoughtItems.Add(itemToBuy);
                cart.BoughtSizes = size;
                context.Carts.Add(cart);
                context.SaveChanges();
            }
            else
            {
                var getCart = (from obj in context.Carts //get the cart
                               where obj.ShoppingCartId == cookie.Value
                               select obj).FirstOrDefault();
                var itemInDb = context.Items.Find(id);  // find the item
                ItemAndSize itemToBuy = new ItemAndSize();
                itemToBuy.Item = itemInDb.ItemId.ToString();

                itemToBuy.Sizes = size;
                getCart.BoughtItems.Add(itemToBuy);

            }

            context.SaveChanges();
            if ((page <= 0) || (page == null))
            {
                ViewBag.id = 1;
            }
            else
                ViewBag.id = page;

            ViewBag.CurrentSort = sortOrder;
            List<Item> items = new List<Item>();
            items = context.Items.ToList();
            List<Item> toRender = new List<Item>();
            foreach (var item2 in items)
            {
                if (item2.Description.ToLower() == "jacket")
                {
                    toRender.Add(item2);
                }
            }
            int pageSize = 8;
            int pageNumber = page ?? 1;
            switch (sortOrder)
            {
                case "high":
                    toRender = toRender.OrderByDescending(obj => obj.Price).ToList();
                    break;
                case "low":
                    toRender = toRender.OrderBy(obj => obj.Price).ToList();
                    break;
            }
            return View(toRender.ToPagedList(pageNumber, pageSize));
        }
       
       

    }
}



