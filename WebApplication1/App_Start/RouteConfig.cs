using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Movies",
                url: "Movies",
                defaults: new { controller = "Movies", action = "Random", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customers",
                url: "Customers",
                defaults: new { controller = "Movies", action = "CustomerList", id = UrlParameter.Optional }
            );
        }
    }
}
