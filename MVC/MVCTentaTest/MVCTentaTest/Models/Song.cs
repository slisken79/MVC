using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTentaTest.Models
{
    public class Song
    {
        public int SongId { get; set; }
        [Required(ErrorMessage ="Du får ej använda stötiga ord"), My, MinLength(4), MaxLength(40)]
        public string Title { get; set; }
        [Required, Range(0.5, 10.5)]
        public decimal Duration { get; set; }
        [Required, My, MinLength(4), MaxLength(40)]
        public string Genre { get; set; }



    }
}