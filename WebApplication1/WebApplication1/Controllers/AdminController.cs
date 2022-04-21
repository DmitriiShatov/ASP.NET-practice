using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        BikeContext context;

        public AdminController(BikeContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var models = context.Models.ToList();
            ViewBag.Models = models;
            var styles = context.Styles.ToList();
            ViewBag.Styles = styles;
            var types = context.Types.ToList();
            ViewBag.Types = types;
            return View(context.Bikes.ToList());
        }

        public IActionResult Create()
        {
            var models = context.Models.ToList();
            ViewBag.Models = models;
            var styles = context.Styles.ToList();
            ViewBag.Styles = styles;
            var types = context.Types.ToList();
            ViewBag.Types = types;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bike bike) 
        {
            if (ModelState.IsValid)
            {
                context.Bikes.Add(bike);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else 
            {
                return Create(); 
            }
        }
        [HttpPost]
        public IActionResult Delete(int bikeId) 
        {
            var bike = context.Bikes.SingleOrDefault(x => x.BikeId == bikeId);
            if (bike != null) 
            {
                context.Bikes.Remove(bike);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id) 
        {
            var models = context.Models.ToList();
            ViewBag.Models = models;
            var styles = context.Styles.ToList();
            ViewBag.Styles = styles;
            var types = context.Types.ToList();
            ViewBag.Types = types;
            return View(context.Bikes.SingleOrDefault(x => x.BikeId == id));
        }
        [HttpPost]
        public IActionResult Update(Bike bike) 
        {
            if (ModelState.IsValid)
            {
                context.Bikes.Update(bike);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else 
            {
                return Update((int)bike.BikeId); 
            }
        }
    }
}
