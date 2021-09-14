using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Repositories;
using WebApplication3.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        Context c = new Context();
        ProductRepository productRepository = new ProductRepository();
        public IActionResult Index()
        {
            return View(productRepository.TList("Category"));
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Product p)
        {
            productRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            productRepository.TDelete(new Product { ProductID = id });
            return RedirectToAction("Index");
        }
        public IActionResult ProductGet(int id)
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
        public IActionResult ProductUpdate(Product p)
        {
            var x = productRepository.GetT(p.ProductID);
            x.ProductName = p.ProductName;
            x.ProductStock = p.ProductStock;
            x.ProductPrice = p.ProductPrice;
            x.ProductInfo = p.ProductInfo;
            x.ProductImageURL = p.ProductImageURL;
            x.ProductID = p.ProductID;
            x.CategoryID = p.CategoryID;
            productRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
