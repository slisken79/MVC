using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab1.Controllers
{
    public class SellController : Controller
    {
        //Upgifft 4: Det saknades en index action och en view på SellController
        // GET: Sell
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult C2C()
        {
            return View();
        }
        public ActionResult Completion()
        {
            return View();
        }
        public ActionResult B2B()
        {
            return View();
        }
        public ActionResult B2C()
        {
            return View();
        }
    }
}
