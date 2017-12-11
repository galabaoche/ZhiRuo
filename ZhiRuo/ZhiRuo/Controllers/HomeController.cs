﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZhiRuo.Controllers
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

        public ActionResult Items()
        {
            ViewBag.Message = "Items.";

            return View();
        }
        public ActionResult Weapons()
        {
            ViewBag.Message = "Weapons.";

            return View();
        }
        
         public ActionResult Armors()
         {
            ViewBag.Message = "Armors.";

            return View();
         }
    }
}