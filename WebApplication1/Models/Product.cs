using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Id Required")]
        public int Pid { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [RegularExpression("[a-zA-Z]{3}",ErrorMessage ="Invalid Name") ]
        public string Pname { get; set; }
        [Required(ErrorMessage = "Price Value Required")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Stock value Required")]
        public int Stock { get; set; }


    }
}
