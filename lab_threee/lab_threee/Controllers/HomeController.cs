using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_threee.Controllers
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

        public ActionResult ViewPage1()
        {
            ViewBag.Message = "Your view page 1.";

            return View();
        }
        public ActionResult Customer()
        {
            ViewBag.Message = "Customer view page.";

            return View();
        }
    }
}