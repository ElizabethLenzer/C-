using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private int? uid
        {
            get 
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        private bool LoggedIn
        {
            get 
            {
                return uid != null;
            }
        }

        [HttpPost("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("/Success")]
        public IActionResult Success()
        {
            if (!LoggedIn)
            {
                return RedirectToAction("Index");
            }
            return View("Success");
        }

        [HttpPost("/LoginPending")]
        public IActionResult LoginPending(LoginUser loginUser)
        {
            if (ModelState.IsValid == false)
            {
                return View("Login");
            }
            User DBUser = db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);
            if (DBUser == null)
            {
                ModelState.AddModelError("LoginEmail", "Email not found");
            }
            if (ModelState.IsValid == false)
            {
                return View("Login");
            }
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult PWCompareResult = hasher.VerifyHashedPassword(loginUser, DBUser.Password, loginUser.LoginPassword);
            if (PWCompareResult == 0)
            {
                ModelState.AddModelError("LoginEmail", "Incorrect Password.");
                return View("Login");
            }
            HttpContext.Session.SetInt32("UserId", DBUser.UserId);
            HttpContext.Session.SetString("FullName", DBUser.FullName());
            return RedirectToAction("Success");
        }

        [HttpGet("/Login")]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("UserId") !=null)
            {
                return RedirectToAction("Success");
            }
            return View("Login");
        }

        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if(db.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email Alredy In Use!");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

                db.Add(user);
                db.SaveChanges();

                HttpContext.Session.SetInt32("UserId", user.UserId);
                HttpContext.Session.SetString("FullName", user.FullName());

                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        private LoginRegistrationContext db;
        public HomeController(LoginRegistrationContext context)
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
