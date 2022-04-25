using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpPost("AddChef")]
        public IActionResult AddChef(Chef chef)
        {
            if(ModelState.IsValid)
            {
                if(chef.Birthday >= DateTime.Today)
                {
                    ModelState.AddModelError("Birthday", "Must be from the past!");
                    return View("AddChef");
                }
                Chef newChef = new Chef
                {
                    FirstName = chef.FirstName,
                    LastName = chef.LastName,
                    Birthday = chef.Birthday
                };
                db.Add(newChef);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else 
            {
                return View("AddChef");
            }
        }
        [HttpGet("New")]
        public IActionResult NewChef()
        {
            return View("AddChef");
        }
        [HttpPost("")]
        // Get Dish
        [HttpGet("Dishes")]
        public IActionResult Dishes ()
        {
            List<Dish> AllDishes = db.dishes
            .Include(Dish => Dish.Creator)
            .ToList();
            ViewBag.alldishes = AllDishes;
            return View("Dishes");
        }

        [HttpGet("")]
        public IActionResult Index ()
        {
            return View();
        }
        private ChefContext db;
        public HomeController(ChefContext context)
        {
            //private//
            db=context;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
