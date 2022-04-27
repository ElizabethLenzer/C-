using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hobbies.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Hobbies.Controllers
{
    public class HobbyController : Controller
    {
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool loggedIn
        {
            get
            {
                return uid != null;
            }
        }
        private HobbyContext db;
        public HobbyController(HobbyContext context)
        {
            db = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (!loggedIn)
            {
                return Redirect("/");
            }

            List<Hobby> hobbies = db.Hobbies
                .Include(h => h.Author)
                .Include(h=> h.HobbyAttendees)
                .ToList();
            ViewBag.hobbies = db.Hobbies
                .Include(h => h.HobbyAttendees)
                .Include(h => h.Author)
                .ToList();

            return View("Dashboard", hobbies);
        }
        // [HttpGet("edit/{hobbyId}")]
        // public IActionResult EditHobby(int hobbyid)
        // {
        //     Hobby hobby = db.Hobbies.FirstOrDefault(h => h.HobbyId == hobbyid);
        //     return View(hobby);
        // }


        [HttpPost("delete/{hobbyId}")]
        public IActionResult DeleteHobby(int hobbyId)
        {
            Hobby hobby = db.Hobbies.FirstOrDefault(h => h.HobbyId == hobbyId);
            if(hobby != null)
            {
                db.Hobbies.Remove(hobby);
                db.SaveChanges();
            }
            return RedirectToAction("Dashboard");
        }

        [HttpPost("RSVP/{hobbyId}")]
        public IActionResult RSVP(int hobbyId)
        {
            if(!loggedIn)
            {
                return RedirectToAction("Index","Home");
            }
            Attendance existingRSVP = db.Attendances
                .FirstOrDefault(RSVP => RSVP.HobbyId == hobbyId && (int)uid == RSVP.UserId);
            
            if(existingRSVP==null){
                Attendance rsvp = new Attendance()
                {
                    HobbyId = hobbyId,
                    UserId = (int)uid
                };
                db.Attendances.Add(rsvp);
            }
            else
            {
                db.Attendances.Remove(existingRSVP);
            }
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        [HttpGet("NewHobby")]
        public IActionResult NewHobby()
        {
            if(!loggedIn)
            {
                return RedirectToAction("Index");
            }
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            return View("NewHobby");
        }

        [HttpPost("CreateNewHobby")]
        public IActionResult Create(Hobby newHobby)
        {
            if(ModelState.IsValid == false)
            {
                ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
                return View("NewHobby");
            }
            newHobby.UserId = (int)uid;
            db.Add(newHobby);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        [HttpGet("Hobby/{hobbyId}")]
        public IActionResult Hobby(int hobbyId)
        {

            Hobby hobby = db.Hobbies
                .Include(p => p.Author)
                .Include(p => p.HobbyAttendees)
                .ThenInclude(rsvp => rsvp.User)
                .FirstOrDefault(h => h.HobbyId == hobbyId);
            if(hobby == null)
            {
                return RedirectToAction("Dashboard");
            }
            return View("Hobby", hobby);
        }
    }
}