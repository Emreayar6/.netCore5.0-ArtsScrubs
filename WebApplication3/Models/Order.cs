using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int ProID { get; set; }       
        public string ProName { get; set; }       
        public string ImageURL { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
