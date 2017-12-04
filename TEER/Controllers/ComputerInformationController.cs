using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEER.Controllers
{
    public class ComputerInformationController : Controller
    {
        // GET: ComputerInformation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewComputerInformation()
        {
            ViewBag.Message = "Your View Computer Information page.";

            return View();
        }

        public ActionResult ViewLocationDetails()
        {
            ViewBag.Message = " Your View Location Details Page.";
            return View();
        }
    }
}