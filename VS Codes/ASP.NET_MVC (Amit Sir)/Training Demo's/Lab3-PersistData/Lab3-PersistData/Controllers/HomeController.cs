using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_PersistData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string strTempData = Convert.ToString(TempData["FortheFullRequest"]); 
            string str2Session = Session["Session1"].ToString(); 
            string str3ViewData = Convert.ToString(ViewData["MyData"]); 
            string str4ViewBag = ViewBag.MyBag;
            ViewData["newviewdata"] = "Default Controller ViewData";
            ViewBag.newviewbag = "Default Controller ViewBag";
            return View();
        }
    }
}