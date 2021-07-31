using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Helpers;
using ShoppingCart.Models;
using ShoppingCart.ViewModels;

namespace ShoppingCart.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(Item => Item.Product.Price * Item.Quantity);
            return View();
        }
    }
}