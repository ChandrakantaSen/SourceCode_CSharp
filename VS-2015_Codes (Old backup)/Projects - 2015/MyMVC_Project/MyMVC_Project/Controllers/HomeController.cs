using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "viewbag msg is running ...!";
            return View();
        }

        public String MyIndex()
        {
            return "Hello ... MyIndex";
        }

        [HttpGet]
        public ViewResult Membership()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Membership(MyMVC_Project.Models.Member obj)
        {
            return View("thanks", obj);
        }
    }
}