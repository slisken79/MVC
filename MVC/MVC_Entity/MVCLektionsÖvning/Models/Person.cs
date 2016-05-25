using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Entity.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }//Nullable stuct
        public Decimal Height { get; set; }
        public Decimal Weigth { get; set; }
        public Adress Adress { get; set; }
        public Person()
        {

        }
    }
}