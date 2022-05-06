using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWeb.Areas.Admin.Models
{
    public class loginModal
    {
        [Required]
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
    }
}