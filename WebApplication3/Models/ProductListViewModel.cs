using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
