﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PS.Controllers
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

        public ActionResult Table()
        {
            return View();
        }

        public ActionResult Seat()
        {
            return View();
        }

        public ActionResult Reserve()
        {
            return View();
        }

        public ActionResult Reserve2()
        {
            return View();
        }
    }
}