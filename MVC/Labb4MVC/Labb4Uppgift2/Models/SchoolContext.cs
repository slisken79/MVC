using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Labb4Uppgift2.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        public SchoolContext() : base("MySchoolDB")
        {
            Database.SetInitializer(new SchoolInitializer());
        }
    }

    public class SchoolInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student()
                {
                    StudentId = 1,
                    LastName = "Essadak",
                    Name = "Youness",
                    Personnumber = "1979-04-07-3573",
                    Address = "Wienergatan 11, 25228 Helsingborg",
                    Grades = new List<Grade>()
                    {
                        new Grade() {GradeId = 1, CourseName = "Javascript", GradeValue = "A"},
                        new Grade() {GradeId = 2, CourseName = "PHP", GradeValue = "A"},
                        new Grade() {GradeId = 3, CourseName = "Jquery", GradeValue = "B"}
                    }
                }
            };
            foreach (var student in students)
            {
                context.Students.Add(student);
            }
            context.SaveChanges();
        }
    }
}