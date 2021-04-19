using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using zad5.Models;

namespace zad5.Data
{
    public class List : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public List(DbContextOptions options) : base(options) { }
    }
}
