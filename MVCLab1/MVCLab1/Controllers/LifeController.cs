using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab1.Controllers
{
    public class LifeController : Controller
    {
        // GET: Life
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SuperMario()
        {
            return View();
        }
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult Live()
        {
            return View();
        }
    }
}
