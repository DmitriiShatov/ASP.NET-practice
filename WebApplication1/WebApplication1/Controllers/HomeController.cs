using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        BikeContext context;
        public HomeController(BikeContext context)
        {
            this.context = context;
        }
        public IActionResult Index(string thx = "") 
        {
            if (!string.IsNullOrEmpty(thx))
                ViewBag.Thx = thx;
            var bikes = context.Bikes.ToList();
            var models = context.Models.ToList();
            ViewBag.Models = models;
            var styles = context.Styles.ToList();
            ViewBag.Styles = styles;
            var types = context.Types.ToList();
            ViewBag.Types = types;
            return View(bikes);
        }

        public IActionResult Buy(int? id) 
        {
            if (id == null)
               return RedirectToAction("Index");
            ViewBag.BikeId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Order order) 
        {
            context.Orders.Add(order);
            context.SaveChanges();
            return RedirectToAction("Index", new { thx = "Thank you for Order!!!" });
        }
    }
}
