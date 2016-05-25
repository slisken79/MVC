using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace Labb4Uppgift2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Person Number")]
        public string Personnumber { get; set; }
        public string Address { get; set; }
        public virtual List<Grade> Grades { get; set; }
    }
}