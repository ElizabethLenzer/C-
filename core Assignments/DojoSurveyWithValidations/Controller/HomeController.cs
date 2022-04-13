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
        public ViewResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.name = Name;
            ViewBag.location = Location;
            ViewBag.language = Language;
            ViewBag.comment = Comment;

            return View();
        }
    }
}