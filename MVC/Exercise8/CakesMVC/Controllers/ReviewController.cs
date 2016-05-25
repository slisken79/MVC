using CakesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CakesMVC.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Add()
        {
            
            return View(new ReviewModel());
        }
        //Post :Review
        [HttpPost]
        public ActionResult Add(ReviewModel Model)
        {
            if (ModelState.IsValid)
            {
                return View("Added");
            }
            return View(Model);
        }
    }
}