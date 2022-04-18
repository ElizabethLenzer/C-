using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            //Womens
            ViewBag.WomenLeagues = _context.Leagues
            .Where(1 => 1.Name.Contains("Women"))
            .ToList();
            //Hockey
            ViewBag.HockeyLeagues = _context.Leagues
            .Where(1 => 1.Sport.Contains("Hockey"))
            .ToList();
            //NonFootBall
            ViewBag.NonFootballLeagues = _context.Leagues
            .Where(1 => !1.Sport.Contains("Football"))
            .ToList();
            //Conference
            ViewBag.ConferenceLeagues = _context.Leagues
            .Where(1 => 1.Name.Contains("Conference"))
            .ToList();
            //Atlantic Leagues
            ViewBag.AtlanticLeagues = _context.Leagues
            .Where(1 => 1.Name.Contains("Atlantic"))
            .ToList();
            //Dallas
            ViewBag.DallasLeagues = _context.Leagues
            .Where(t => t.Location.Contains("Dallas"))
            .ToList();
            //Raptors
            ViewBag.RaptorsLeagues = _context.Leagues
            .Where(t => t.TeamName.Contains("Raptors"))
            .ToList();
            //Team With City
            ViewBag.TeamWithCity = _context.Leagues
            .Where(t => t.Location.Contains("City"))
            .ToList();
            //Teams That Begin With a T
            ViewBag.TeamStartWithT = _context.Leagues
            .Where(1 => 1.Name.Contains("T"))
            .ToList();
            //All Teams By Name starting with A
            ViewBag.TeamByName = _context.Leagues
            .Where(1 => 1.Name.Contains("Atlantic"))
            .ToList();
            //All Teams by Name Decending
            ViewBag.TeamDecending = _context.Leagues
            .Where(1 => 1.Name.Contains("Atlantic"))
            .ToList();
            //Players with the last name of Cooper
            ViewBag.LastNameCooper = _context.Leagues
            .Where(1 => 1.Name.Contains("Atlantic"))
            .ToList();
            //Players with the First Name Josh
            ViewBag.FirstNameJosh = _context.Leagues
            .Where(1 => 1.Name.Contains("Atlantic"))
            .ToList();
            //Players with the Last Name Cooper but not first name Josh
            ViewBag.LastNameCooperNotJosh = _context.Leagues
            .Where(1 => 1.Name.Contains("Atlantic"))
            .ToList();
            //Players with the First Name Alex and Wyatt
            ViewBag.FirstNameAlexanderAndWyatt = _context.Leagues
            .Where(1 => 1.Name.Contains("Atlantic"))
            .ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}