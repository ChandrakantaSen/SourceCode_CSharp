using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab14_TestingNDeployment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("HomePage");
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is About Us Page";
            return View();
        }

        public ActionResult ViewMaps()
        {
            return View();
        }
    }
}