using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: TicTacToe
        public ActionResult Index()
        {
            var ticModel = new TicTacToeModel();
            this.Session["Tic"] = ticModel;
            return View(ticModel);

        }
        //public ActionResult Reset()
        //{
        //    var ticModel = new TicTacToeModel();
        //    this.Session["Tic"] = ticModel;
        //    return View(ticModel);

        //}
        [HttpPost]
        public ActionResult Index(int? choice)
        {
            if (choice == 10)
            {
                var ticModel2 = new TicTacToeModel();
                this.Session["Tic"] = ticModel2;
                return View(ticModel2);
            }         
            var ticModel = (TicTacToeModel) this.Session["Tic"];
            ticModel.Human(choice.Value);
           
            return View(ticModel);
            
        }
    }
}