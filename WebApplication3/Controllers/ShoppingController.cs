using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    [AllowAnonymous]
    public class ShoppingController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        Context c = new Context();

        public IActionResult Index()
        {
            ViewBag.Name = "DotNet, How?";
            ProductListViewModel pm = new ProductListViewModel();
            pm.Products = productRepository.TList();
            pm.CurrentCategory = "productCategory";
            return View(pm);
        }
        public IActionResult ShoppingGet(int id)
        {
        var x = productRepository.GetT(id);
        List<SelectListItem> values = (from y in c.Categories.ToList()
                                       select new SelectListItem
                                       {
                                           Text = y.CategoryName,
                                           Value = y.CategoryID.ToString()
                                       }).ToList();
        ViewBag.v1 = values;
        Product pr = new Product()
        {
            ProductID = x.ProductID,
            CategoryID = x.CategoryID,
            ProductName = x.ProductName,
            ProductImageURL = x.ProductImageURL,
            ProductInfo = x.ProductInfo,
            ProductPrice = x.ProductPrice,
            ProductStock = x.ProductStock
        };
        return View(pr);
        }
    }
    
}
