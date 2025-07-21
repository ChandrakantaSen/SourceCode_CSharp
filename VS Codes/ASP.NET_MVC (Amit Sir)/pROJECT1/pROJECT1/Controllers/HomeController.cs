using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pROJECT1.Models;

namespace pROJECT1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Summation(Add add)
        {
            return View("Summation", add);
        }
    }
}