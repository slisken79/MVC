using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4Uppgift2.Models;

namespace Labb4Uppgift2.Controllers
{
    public class GradeController : Controller
    {
        public PartialViewResult _List(int studentId)
        {
            using (SchoolContext context = new SchoolContext())
            {
                 return PartialView(context.Students.Find(studentId).Grades.ToList());
            }
        }

        public PartialViewResult _Create(int studentId)
        {
            return PartialView(new Grade {StudentId = studentId});
        }
        [HttpPost]
        public ActionResult _Create(Grade model)
        {
            using (SchoolContext context = new SchoolContext())
            {
                context.Students.Find(model.StudentId).Grades.Add(model);
                context.SaveChanges();
                return RedirectToAction("_List", new { studentId = model.StudentId});
            }
        }
    }
}