using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCLab1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            ROUTES.MAPROUTE(
               NAME: "EYE",
               URL: "LASER/{ACTION}/{ID}",
               DEFAULTS: NEW { CONTROLLER = "LASER", ACTION = "EYE", ID = URLPARAMETER.OPTIONAL }
            );
          
            ROUTES.MAPROUTE(
                NAME: "HEALTH",
                URL: "LIFE/{ACTION}/{ID}",
                DEFAULTS: NEW { CONTROLLER = "LIFE", ACTION = "HEALTH", ID = URLPARAMETER.OPTIONAL }
            );
        

            ROUTES.MAPROUTE(
              NAME: "B2B",
                URL: "SELL/{ACTION}/{ID}",
                DEFAULTS: NEW { CONTROLLER = "SELL", ACTION = "B2B", ID = URLPARAMETER.OPTIONAL }
            );
            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
