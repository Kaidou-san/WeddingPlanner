using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                //Email must be unique!
                if (_context.Users.Any(e => e.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email Taken already");
                    return View("Index");
                }
                else
                {
                    // We have verification that all is well and we can add to the database
                    // WE NEED TO HASH OUR PW
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("LoggedIn", newUser.UserId);
                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser logUser)
        {
            if (ModelState.IsValid)
            {
                //VERIFY EMAIL GIVEN IS THE DATABASE
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == logUser.LEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                //CHECK THE PW VS THE PW IN THE USER HAS IN THE DATABASE
                PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userInDb.Password, logUser.LPassword);
                if (result == 0)
                {
                    //IF ITS 0 THAT MEANS WE FAILED TO VERIFY
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.SetInt32("loggedIn", userInDb.UserId);
                    //AFTER SUCCESSFULLY DO BOTH, WE HEAD TO THE SUCCESS PAGE
                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            int? loggedIn = HttpContext.Session.GetInt32("loggedIn");
            if (loggedIn != null)
            {
                ViewBag.User = _context.Users.Include(s => s.GuestRSVP)
                .ThenInclude(d => d.Wedding).FirstOrDefault(a => a.UserId == (int)loggedIn);
                ViewBag.AllWeddings = _context.Weddings.Include(w => w.GuestsWhoGoing).ToList();
                return View();
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("addWedding")]
        public IActionResult addWedding()
        {
            return View();
        }

        [HttpPost("WeddingToDb")]
        public IActionResult WeddingToDb(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                newWedding.UserId = (int)HttpContext.Session.GetInt32("loggedIn");
                _context.Add(newWedding);
                _context.SaveChanges();
                return RedirectToAction("success");
            }else {
                return View("addWedding");
            }
        }

        [HttpGet("RSVP/{UserId}/{WeddingId}")]
        public IActionResult RSVPWedding(int UserId, int WeddingId)
        {
            int? loggedIn = HttpContext.Session.GetInt32("loggedIn");
            if(loggedIn != null)
            {
                if((int)loggedIn != UserId)
                {
                    return RedirectToAction("logout");
                } else {
                    Guest newGuest = new Guest();
                    newGuest.UserId = UserId;
                    newGuest.WeddingId = WeddingId;
                    _context.Guests.Add(newGuest);
                    _context.SaveChanges();
                    return RedirectToAction("success");
                }
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("unRSVP/{UserId}/{WeddingId}")]
        public IActionResult unRSVPWedding(int UserId, int WeddingId)
        {
            int? loggedIn = HttpContext.Session.GetInt32("loggedIn");
            if(loggedIn != null)
            {
                if((int)loggedIn != UserId)
                {
                    return RedirectToAction("logout");
                } else {
                    Guest newGuest = new Guest();
                    Guest GuestToRemove = _context.Guests
                    .FirstOrDefault(a => a.WeddingId == WeddingId && a.UserId == UserId);
                    _context.Guests.Remove(GuestToRemove);
                    _context.SaveChanges();
                    return RedirectToAction("success");
                }
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("wedding/{WeddingId}")]
        public IActionResult OneWedding(int WeddingId)
        {
            ViewBag.OneWedding = _context.Weddings.Include(a => a.GuestsWhoGoing)
            .ThenInclude(s => s.User)
            .FirstOrDefault(m => m.WeddingId == WeddingId);
            ViewBag.AllWeddings = _context.Weddings.ToList();
            return View();
        }


    }
}
