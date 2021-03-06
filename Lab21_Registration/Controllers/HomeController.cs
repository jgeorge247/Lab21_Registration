﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21_Registration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //this will go to my registration view
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Welcome(string firstName = "John", string lastName = "Smith",
            string email = "John@yahoo.com", int phone = 555-555-5555, string password = "password")
        {
            ViewBag.data = firstName;
            ViewBag.lastName = lastName;
            ViewBag.email = email;
            ViewBag.phone = phone;
            ViewBag.password = password;
            return View();
        }
    }
}