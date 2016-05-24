using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Labb4Uppgift2.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        [DisplayName("Course")]
        public string  CourseName { get; set; }

        [DisplayName("Grade")]
        public string GradeValue { get; set; }
        public virtual int StudentId { get; set; }
    }
}