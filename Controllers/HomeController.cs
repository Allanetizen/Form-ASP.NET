using Microsoft.AspNetCore.Mvc;
using System;
using PartyInvitess.Models;


namespace PartyInvitess.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //TOD: STORE RESPONSE FROM Guest
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
    }
}