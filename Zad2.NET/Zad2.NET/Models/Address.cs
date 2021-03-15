using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zad2.NET.Models
{
    public class Address
    {

        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60,MinimumLength = 3), Required(ErrorMessage = "Polejest obowiązkowe")]
        

        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
    }

}
