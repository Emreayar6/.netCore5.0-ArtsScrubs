using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {
        ProductRepository productRepository = new ProductRepository();   
        OrderRepository orderRepository = new OrderRepository();
        public IActionResult Index()
        {
            return View(orderRepository.TList());
        }

        //public IActionResult AddToCart()
        //{

        //    return View(orderRepository.TList());
        //}

        
        public IActionResult AddToCart(int id)
        {
            var x = productRepository.GetT(id);
            Order or = new Order()
            {               
                Price = x.ProductPrice,
                ImageURL = x.ProductImageURL,
                ProID = x.ProductID,
                Quantity = 1,
                ProName = x.ProductName
            };
            orderRepository.TAdd(or);


            return RedirectToAction("Index");
        }
        public IActionResult DeleteItem(int id)
        {
            orderRepository.TDelete(new Order { OrderID = id });
            return RedirectToAction("Index");
        }

        public IActionResult Address()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
    }
}
