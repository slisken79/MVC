using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CakesMVC.Models
{
    public class ReviewModel :IValidatableObject
    {
        public int ReviewId { get; set; }
        [Required, MinLength(5), MaxLength(30)]
        public string Name { get; set; }
        [Required, MaxLength(4000)]
        public string Ingredients { get; set; }
        [Required, MinLength(100), MaxLength(4000)]
        public string Summary { get; set; }
        [Required, Range(1,180)]
        public int CookingTime { get; set; }
        [Required, MaxLength(4000)]
        public string Instructions { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }

    
}