using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTentaTest.Models
{
    public class MyAttribute :ValidationAttribute
    {
        //public override bool IsValid(object value)
        //{
        //    var input = value.ToString().ToLower();
        //    if(input.Contains("Vapen") || input.Contains("drog"))
        //        {
        //        return false;
        //    }
        //    return true;
           
        //}
        //public override string FormatErrorMessage(string name)
        //{
        //    return ("Använd andra ord");
        //}
        public override bool IsValid(object value)
        {
            var input = value.ToString().ToLower();
            if (input.Contains("gun") || input.Contains("fight") || input.Contains("knife"))
            {
                return false;
            }
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return ("Du får ej använda sån ord");
        }
    }
}