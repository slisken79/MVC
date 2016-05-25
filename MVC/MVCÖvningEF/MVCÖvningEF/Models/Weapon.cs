using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEF.Models
{
    public class Weapon
    {
        public int WeaponId { get; set; }

        public string Name { get; set; }
        public decimal Speed { get; set; }
        public decimal Weigth { get; set; }
        public decimal Range { get; set; }
        public IList<Ninja> Ninjas { get; set; }


    }
}