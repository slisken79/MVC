using Labb4MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labb4MVC.Controllers
{
    public class Game21Controller : Controller
    {
        // GET: Game21
        public ActionResult Index()
        {
            return View();
        }
        // GET: Game21
        public PartialViewResult Spel()
        {
            var game21 = new Game21();
            Session["game21"] = game21;

            return PartialView(game21);
        }

        // POST: Game21
        [HttpPost]
        public PartialViewResult Spel(int add)
        {
            var game21 = (Game21)Session["game21"];
            game21.AddNr(add);
            return PartialView(game21);
        }
    }
}