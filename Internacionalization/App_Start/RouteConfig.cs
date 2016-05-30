﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Internacionalization
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { culture = string.Empty, controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}