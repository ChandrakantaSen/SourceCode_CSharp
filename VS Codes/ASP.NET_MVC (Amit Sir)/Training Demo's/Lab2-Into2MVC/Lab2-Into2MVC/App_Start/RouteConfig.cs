using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab2_Into2MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Route will be recognized by Home
            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
                );

            // Route will be recognized by Home/Home
            routes.MapRoute(
                name: "Home1",
                url: "Home/Home",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
                );

            //Setting as default View of the Project
            routes.MapRoute(
                name: "Home2",
                url: "",
                defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
