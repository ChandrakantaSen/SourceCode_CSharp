using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_Working_with_Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //working with if statement
        public ActionResult ifStatement()
        {
            return View();
        }

        //Working with switch case
        public ActionResult switchCase()
        {
            ViewBag.ProductCount = 15;
            return View();
        }

        //User input through Razor Syntax
        public ActionResult UserInput()
        {
            return View();
        }

        //Working with loops
        public ActionResult Looping()
        {
            return View();
        }

        //Working with Arrays
        public ActionResult Arrays()
        {
            return View();
        }
    }
}