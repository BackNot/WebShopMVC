using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class Administrator
    {
        [Key]
        public int AdministratorId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }


    }
}