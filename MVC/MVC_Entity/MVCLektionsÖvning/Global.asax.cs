using MVC_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Entity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            using (var context = new PersonContext())
            {
                Person pelle = new Person()
                {
                    PersonId = 8,
                    Name = "Pelle",
                    
                };
                context.Persons.Add(pelle);
                context.SaveChanges();
            }
        }
    }
}
