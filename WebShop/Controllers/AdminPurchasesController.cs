using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Context;
using WebShop.Models;

namespace WebShop.Controllers
{
    [Authorize]
    public class AdminPurchasesController : Controller
    {
        WebShopDb context = new WebShopDb();
        //
        // GET: /AdminPurchases/
        public ActionResult Index()
        {
            List<Purchase> purchases = context.Purchases.ToList();
            return View(purchases);
        }
        public ActionResult Sent(int id)
        {
            var purch = context.Purchases.Find(id);
            purch.Status = PurchaseStatus.Sent;
            context.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());

        }
        public ActionResult Delete(int id)
        {
            var purch = context.Purchases.Find(id);
            purch.Status = PurchaseStatus.Deleted;
            context.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());

        }
        public ActionResult Pending (int id)
        {
            var purch = context.Purchases.Find(id);
            purch.Status = PurchaseStatus.Pending;
            context.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
        public ActionResult DeleteAll()
        {
            var entities = from obj in context.Purchases
                           where obj.Status == PurchaseStatus.Deleted
                           select obj;
            foreach (var item in entities)
            {
                foreach (var purch in item.PurchasedItems)
                {
                    purch.PurchaseId = null;
                }
            }          
            context.Purchases.RemoveRange(entities);
            
            context.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());

        }
	}
}