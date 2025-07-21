using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_PersistData.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        // Based on time we shall greet the User
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 5 && hour < 12)
                ViewBag.Greeting = "Good Morning!";
            else if (hour >= 12 && hour < 16)
                ViewBag.Greeting = "Good Afternoon!";
            else if (hour >= 16 && hour < 20)
                ViewBag.Greeting = "Good Evening!";
            else
                ViewBag.Greeting = "Please go to sleep its late!";
            return View();
        }

        public ActionResult CheckDifference()
        {
            Session["Session1"] = "Until Browser Closes";
            TempData["FortheFullRequest"] = "For the Full Request";
            ViewData["MyData"] = "ControllertoView";
            ViewBag.MyBag = "SingleRequest Either ControllertoView OR ControllertoController";
            
            return RedirectToAction("Index", "Home");
        }
    }
}