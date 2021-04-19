using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using zad5.Data;
using zad5.Models;

namespace zad5.Pages.bazaProduct
{
    public class IndexModel : PageModel
    {
        private readonly zad5.Data.List _context;

        public IndexModel(zad5.Data.List context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
