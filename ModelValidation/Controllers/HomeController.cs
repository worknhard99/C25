﻿using System;
using System.Web.Mvc;
using ModelValidation.Models;
namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult MakeBooking()
        {
            return View(new Appointment { Date = DateTime.Now });
        }
        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            // statements to store new Appointment in a
            // repository would go here in a real project
            return View("Completed", appt);
        }
    }
}