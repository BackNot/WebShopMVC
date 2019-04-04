using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
       public partial class ItemAndSize
    {
           public int ItemAndSizeId { get; set; }

           public Purchase PurchaseId { get; set; }

           public string Item { get; set; }

           public string Sizes { get; set; }
    }
}