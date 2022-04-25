using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExamProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ExamProject.Controllers
{
    public class MeetupController : Controller
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
        private MeetupCenterContext db;
        public MeetupController(MeetupCenterContext context)
        {
            db = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (!loggedIn)
            {
                return RedirectToAction("Index");
            }

            List<Meetup> Meetups = db.Meetups
                .Include(m => m.Author)
                .Include(m=> m.MeetupAttendees)
                .ToList();
            ViewBag.Meetups = db.Meetups
                .Include(m => m.MeetupAttendees)
                .Include(m => m.Author)
                .ToList();

            return View("Dashboard", Meetups);
        }

        [HttpPost("delete/{Id}")]
        public IActionResult DeleteMeetup(int meetupId)
        {
            Meetup meetup = db.Meetups.FirstOrDefault(m => m.MeetupId == meetupId);
            if(meetup != null)
            {
                db.Meetups.Remove(meetup);
                db.SaveChanges();
            }
            return RedirectToAction("Dashboard");
        }

        [HttpPost("RSVP/{meetupId}")]
        public IActionResult RSVP(int meetupId)
        {
            if(!loggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            Attendance existingRSVP = db.Attendances
                .FirstOrDefault(RSVP => RSVP.MeetupId == meetupId && (int)uid == RSVP.UserId);

            if(existingRSVP == null)
            {
                Attendance rsvp = new Attendance()
                {
                    MeetupId = meetupId,
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


        [HttpGet("NewMeetup")]
        public IActionResult NewMeetup()
        {
            if(!loggedIn)
            {
                return RedirectToAction("Index");
            }
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            return View("NewMeetup");
        }

        [HttpPost("CreateNewMeetup")]
        public IActionResult Create(Meetup newMeetup)
        {
            if(ModelState.IsValid == false)
            {
                ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
                return View("NewMeetup");
            }
            newMeetup.UserId = (int)uid;
            db.Add(newMeetup);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        [HttpGet("Meetup/{meetupId}")]
        public IActionResult Meetup(int meetupId)
        {

            Meetup meetup = db.Meetups
                .Include(p => p.Author)
                .Include(p => p.MeetupAttendees)
                .ThenInclude(rsvp => rsvp.User)
                .FirstOrDefault(m => m.MeetupId == meetupId);
            if(meetup == null)
            {
                return RedirectToAction("Dashboard");
            }
            return View("Meetup", meetup);
        }
    }
}