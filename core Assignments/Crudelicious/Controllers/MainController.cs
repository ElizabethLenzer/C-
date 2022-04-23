using System;
using Microsoft.AspNetCore.Mvc;
using Crudelicious.Models;
using System.Linq;
using System.Collections.Generic;

namespace Crudelicious.Controllers
{
    public class MainController : Controller
    {
        private DishContext database;
        public MainController(DishContext context)
        {
            database = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> dishes = database.Dishes.ToList();
            return View(dishes);
        }
        [HttpGet("new")]
        public IActionResult NewDish()
        {
            return View();
        }
        [HttpPost("addDish")]
        public IActionResult AddDish(Dish post_dish)
        {
            database.Add(post_dish);
            //Adding the Changes
            database.SaveChanges();
            //Saving the Changes
            Console.WriteLine(post_dish.Name);
            Console.WriteLine(post_dish.Chef);
            Console.WriteLine(post_dish.Tastiness);
            Console.WriteLine(post_dish.Calories);
            Console.WriteLine(post_dish.Description);
            //making sure it works
            
            //Add the dish from the post to the database
            //redirect
            ////dont want to render on a post because form can be resubmitted without permission
            return RedirectToAction("Index");
            //redirect to rout
            // return Redirtect("/")
        }
        // Grabs Specific Dish
        [HttpGet("{dish_id}")]
        public IActionResult ViewDish(int dish_id)
        {
            Dish dish = database.Dishes.FirstOrDefault(d => d.DishID == dish_id);

            Console.WriteLine(dish_id);
            return View(dish);
        }
    }
}