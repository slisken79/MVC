using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestEdderkoppen
{
   public class Spindelmannen
    {
        public double GetCircumference(double radius)
        {
            var result = Math.PI * (radius * 2);
            return result;
            //throw new NotImplementedException();
        }
    }
}
