using System;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;
using WebShop.Context;
namespace WebShop.Controllers
{
    public class AdminController : Controller
    {
        WebShopDb context = new WebShopDb();
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item item)
        {
            if (ModelState.IsValid) // if everything is good
            {

                context.Items.Add(item);
                context.SaveChanges();
                return Content("<script>if (confirm('Item was created.')) {    (window.location.replace('/Admin/Index'));} else {(window.location.replace('/Admin/Index'));}</script>");


            }
            else
                return View(item);
        }
        public ActionResult Edit()
        {
            return View(context.Items.ToList());
        }
        public ActionResult Change(int id)
        {

            Item item = context.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Change([Bind(Include = "ItemId,Image,Name,Description,Size,AdditionalInformation,Price")]Item item)
        {
            // replace old values with the new item's values
            if (ModelState.IsValid)
            {
                Item originalItem = context.Items.Find(item.ItemId);


                context.Entry(originalItem).CurrentValues.SetValues(item);
                context.Entry(originalItem).State = EntityState.Modified;


                context.SaveChanges();
                return Content("<script>if (confirm('Item was edited.')) {    (window.location.replace('/Admin/Index'));} else {(window.location.replace('/Admin/Index'));}</script>");

            }
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Item item)
        {
            var itemToRemove = context.Items.Find(item.ItemId);
            if (itemToRemove != null)
            {
                ViewBag.deletionFailed = false;

                context.Items.Remove(itemToRemove);
                context.SaveChanges();
                return Content("<script>if (confirm('Item was deleted.')) {    (window.location.replace('/Admin/Index'));} else {(window.location.replace('/Admin/Index'));}</script>");
            }
            else
            { // if there is no such ID
                ViewBag.deletionFailed = true;
                return View();
            }
        }
    }
}