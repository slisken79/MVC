using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTentaTest.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Band { get; set; }

        public List<Song> Songs { get; set; }



    }
}