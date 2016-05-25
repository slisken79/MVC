using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4Uppgift2.Models;

namespace Labb4Uppgift2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            using (SchoolContext context = new SchoolContext())
            {
                return View(context.Students.ToList());
            }
            
        }

        public ActionResult Detail(int id)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return View(context.Students.Find(id));
            }
        }
    }
}