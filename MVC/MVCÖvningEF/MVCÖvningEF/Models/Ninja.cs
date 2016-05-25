using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEF.Models
{
    public class Ninja
    {
        public int NinjaId { get; set; }

        public string  Name { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public Weapon Weapons { get; set; }

    }
}