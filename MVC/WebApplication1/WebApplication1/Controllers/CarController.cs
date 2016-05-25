using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Driver()
        {
            //Bygga modell o skicka till viewn
            return View();
        }
        public ActionResult Brumbrum()
        {
            return View();
        }
        public ActionResult ViewDataTransfer()
        {

            ViewData["Beauty"] = "Det är en häst..";
            return View();
        }
        public ActionResult ViewBagTransfer()
        {

            ViewBag.Lisa = "Smurfarna är blåa..";
            return View();
        }
        public ViewResult OddNumbers()
        {
            var oddNumbers = (ParallelEnumerable.Range(10, 40)).Where(x => x% 2 != 0).Select(x => x).ToList();
            ViewData.Model = oddNumbers;
            return View();
        }
    }
}