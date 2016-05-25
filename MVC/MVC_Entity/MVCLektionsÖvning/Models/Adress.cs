using System.Collections.Generic;

namespace MVC_Entity.Models
{
    public class Adress
    {
        public Adress()
        {

        }
        public int AdressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public IList<Person> Persons { get; set; }

    }
}