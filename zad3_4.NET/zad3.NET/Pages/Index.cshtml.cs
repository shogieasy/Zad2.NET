using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zad3.NET.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace zad3.NET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz FizzBuzz {get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        
        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
             FizzBuzz.oblicz();

            if (ModelState.IsValid)
           {
        
                  HttpContext.Session.SetString("SessionAddress", JsonConvert.SerializeObject(FizzBuzz));
                //  return RedirectToPage("./ostatnio_szukane"); przechodzenie do zapisanych danych
            }
            return Page();
        }



    }
}
