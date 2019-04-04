using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public partial class Cart 
    {
        [Key]
        public int CartId { get; set; }

        public string ShoppingCartId { get; set; }
       
     
        public string Name { get; set; }
  
        public string Description { get; set; }
      
        public string Size { get; set; }
      
        public string AdditionalInformation { get; set; }
  
        public decimal Price { get; set; }

        public string BoughtSizes { get; set; } // hold item's bought sizes

        public virtual IList<ItemAndSize> BoughtItems { get; set; } // save bought Item and sizes
       

    }
}