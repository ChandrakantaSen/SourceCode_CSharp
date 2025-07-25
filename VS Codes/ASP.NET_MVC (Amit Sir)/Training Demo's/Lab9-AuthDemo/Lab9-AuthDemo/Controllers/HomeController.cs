﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab9_AuthDemo.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [OverrideAuthorization]
        public ActionResult About()
        {
            return View();
        }
    }
}