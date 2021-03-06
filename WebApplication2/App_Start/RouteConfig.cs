﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Student",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Student", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Teacher",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Teacher", action = "Teacher", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Dynamic",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dynamic", action = "Dynamic", id = UrlParameter.Optional }
            );

        }
    }
}
