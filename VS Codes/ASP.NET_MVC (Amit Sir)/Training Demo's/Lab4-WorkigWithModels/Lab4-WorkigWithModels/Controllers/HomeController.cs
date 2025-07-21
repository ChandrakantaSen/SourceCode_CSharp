using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_WorkigWithModels.Models;

namespace Lab4_WorkigWithModels.Controllers
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

        [NonAction]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Code for Registration for Training
        [HttpGet]
        public ViewResult RegisterNow()
        {
            return View();
        }

        //Registration Response
        [HttpPost]
        public ViewResult RegisterNow(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        [ActionName("Services")]
        public ViewResult OurOfferings()
        {
            return View();
        }
    }
}