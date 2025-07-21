using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab12_FilterDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(CacheProfile="1MinuteCache")]
        public ActionResult Index()
        {
            return View();
        }

        
        [ChildActionOnly]
        [HandleError(ExceptionType = typeof(Exception), View = "Error")]
        [OutputCache(Duration = 40)]
        public ActionResult Countries(List<string> countryNames)
        {
            return View(countryNames);
        }
    }
}