using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckPrimeDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult CheckPrime()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckPrime(int number)
        {
            ViewBag.num = number;
            return View("CheckPrimeResult");
        }
    }
}