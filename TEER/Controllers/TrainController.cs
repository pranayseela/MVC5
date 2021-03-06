﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEER.Controllers
{
    public class TrainController : Controller
    {
        // GET: Train
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewTrainInformation()
        {
            ViewBag.Message = "Your View Train Information page.";

            return View();
        }
        public ActionResult EditTrainInformation()
        {
            ViewBag.Message = "Your Edit Train Information page.";

            return View();
        }
        public ActionResult ViewTrainDetails()
        {
            ViewBag.Message = "Your View Train Details page.";

            return View();
        }
        public ActionResult TrainDetailsSearch()
        {
            ViewBag.Message = "Your Train Details Search page.";

            return View();
        }
    }
}