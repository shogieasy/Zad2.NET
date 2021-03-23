using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace zad3.NET.Models
{
    public class FizzBuzz
    {

        [Display(Name = "Podaj liczbe z zakresu 1-1000")]
        //[Required(ErrorMessage ="Polejest obowiązkowe")] nie działa na intach
        [Range(1, 1000)] //zakres


        public int liczba  { get; set; }
        public string wynik { get; set; }



    }


}
