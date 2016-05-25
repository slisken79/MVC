using MVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCEF
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            using (var context = new NinjaContext())
            {
                Ninja ninja1 = new Ninja()
                {
                    NinjaId = 8,
                    Name = "Freddie"
                };
                context.Ninjas.Add(ninja1);
                context.SaveChanges();
            }
        }
    }
}
