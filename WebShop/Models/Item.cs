using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WebShop.Models
{
    public class Item 
    {
        
       public int ItemId { get; set; }

        [DisplayName("Image path:")]
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string AdditionalInformation { get; set; }
        [Required]
        public decimal Price { get; set; }


    }
}