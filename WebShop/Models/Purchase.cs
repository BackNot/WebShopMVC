using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebShop.Models
{
    public enum PurchaseStatus
    {
        Pending,
        Sent,
        Deleted
    }
    public class Purchase
    {
     [DefaultValue("1")]   
        public int PurchaseID { get; set; }

        [Required]
        [DisplayName("First Name:")]

        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name:")]
        public string LastName { get; set; }

        [Required]

        public string Adress { get; set; }

         [DisplayName("Additional Information:")]
        public string Information { get; set; }

        [DisplayName("TOTAL:")]
        public decimal Price { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Email { get; set; }

        [DisplayName("Status:")]
        public PurchaseStatus Status { get; set;}

        public virtual IList<ItemAndSize> PurchasedItems { get; set; } // save bought Item and sizes

        
    }
}