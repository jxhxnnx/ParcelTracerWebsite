using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PaPlWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Submit",
                url: "submit",
                defaults: new { controller = "Submit", action = "Index" }
            );


            routes.MapRoute(
                name: "Track",
                url: "track",
                defaults: new { controller = "Track", action = "Index"}
            );

            routes.MapRoute(
                name: "ReportHop",
                url: "reportHop",
                defaults: new { controller = "ReportHop", action = "Index" }
            );

            routes.MapRoute(
                name: "ReportArrival",
                url: "reportArrival",
                defaults: new { controller = "ReportArrival", action = "Index" }
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
