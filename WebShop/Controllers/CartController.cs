using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;
using WebShop.Context;

namespace WebShop.Controllers
{
    public class CartController : Controller
    {
        WebShopDb context = new WebShopDb();
        //
        // GET: /Cart/
        public ActionResult Clear()
        {
            var temp = new HttpCookie("ShoppingCartId");
            temp.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(temp);
           
           // context.Carts.RemoveRange(context.Carts.ToList()); // Clear all items in cart by deleting them from Db
            //context.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
        public ActionResult Buy()
        {
            Purchase purch = new Purchase();
          //  purch.CartItems = context.Carts.ToList();
            return View(purch); 
        }
        [HttpPost]
        public ActionResult Buy(Purchase purch)
        {
           // if (purch.PurchasedItems == null) Response.Redirect("~/Home/Index");
            if(ModelState.IsValid)
            {
                purch.PurchasedItems = new List<ItemAndSize>();
               
                HttpCookie cookie = Request.Cookies.Get("ShoppingCartId"); // get the cookie
                var cartObj = (from obj in context.Carts // get the cart
                               where obj.ShoppingCartId == cookie.Value
                               select obj).FirstOrDefault();

                foreach (var item in cartObj.BoughtItems)
                {
                    purch.PurchasedItems.Add(item); // add it to the new list
                }
               
                context.Purchases.Add(purch); // add to Db
                context.SaveChanges();
                return RedirectToAction("ThankYou");// if purchase was made 
            }
            else
            {
           //     purch.CartItems = context.Carts.ToList(); // populate the list again

                return View(purch); // if something failed return the view 

            }

        }
        public ActionResult ThankYou()
        {
            // Thank the client , remove the cookie and cart
            var cookie = new HttpCookie("ShoppingCartId");
          
            var cartObj = (from obj in context.Carts // get the cart
                           where obj.ShoppingCartId == cookie.Value
                           select obj).FirstOrDefault();
            if (cartObj != null)
            {
                context.Carts.Remove(cartObj);
            }
            context.SaveChanges();
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            return View();
        }
	}
}