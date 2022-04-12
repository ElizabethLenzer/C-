using Microsoft.AspNetCore.Mvc;
using System;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Form()
        {
            return View();
        }
        [HttpPost("result")]
        public ViewResult Result(string Name, string Location, string Favorite, string Comment);
        {
            ViewBag.name = Name;
            ViewBag.location = Location;
            ViewBag.favorite = Favorite;
            ViewBag.comment = Comment;

            return View();
        }
    }
}