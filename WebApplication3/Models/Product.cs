using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductInfo { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImageURL { get; set; }
        public int ProductStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
