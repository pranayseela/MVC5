using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEER.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeneralOrder()
        {
            ViewBag.Message = "Your General Order page.";

            return View();
        }

        public ActionResult OperationNotice()
        {
            ViewBag.Message = "Your Operation Notice page.";

            return View();
        }
        public ActionResult GeneralNoticeNumber()
        {
            ViewBag.Message = "Your General Notice Number page.";

            return View();
        }
        public ActionResult SpecialSchedule()
        {
            ViewBag.Message = "Your Special Schedule page.";

            return View();
        }
        public ActionResult CrewManagementSystemBook()
        {
            ViewBag.Message = "Your Crew Management System Book.";

            return View();
        }
        public ActionResult ViewGeneralOrder()
        {
            ViewBag.Message = "Your General Order page.";

            return View();
        }
        public ActionResult Bulletin()
        {
            ViewBag.Message = "Your Bulletin page.";

            return View();
        }
        public ActionResult CrewAssignment()
        {
            ViewBag.Message = "Your CrewAssignment page.";

            return View();
        }
    }


}