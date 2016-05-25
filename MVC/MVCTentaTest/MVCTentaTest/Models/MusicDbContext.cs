using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTentaTest.Models
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artist { get; set; }

        public MusicDbContext() : base("MusicDB")
        {
            Database.SetInitializer<MusicDbContext>(new MusicInitializer());
        }

    }

    public class MusicInitializer : DropCreateDatabaseAlways<MusicDbContext>
    {
        protected override void Seed(MusicDbContext ctx)
        {
            List<Song> list1 = new List<Song>();
            list1.Add(new Song() { SongId = 1, Title = "Love song", Duration = 3.5M, Genre = "Classic" });
            list1.Add(new Song() { SongId = 2, Title = "I wonder", Duration = 2.5M, Genre = "Classic" });


            var artist1 = new Artist()
            {
                ArtistId = 1,
                Name = "Adam",
                Age = 33,
                Band = "Roxette",
                Songs = list1
            };
            List<Song> list2 = new List<Song>();
            list2.Add(new Song() { SongId = 1, Title = "Rock song", Duration = 4.5M, Genre = "Rock" });
            list2.Add(new Song() { SongId = 2, Title = "Happy", Duration = 4.7M, Genre = "Classic" });


            var artist2 = new Artist()
            {
                ArtistId = 2,
                Name = "Eric",
                Age = 25,
                Band = "The Yard",
                Songs = list2
            };
            List<Song> list3 = new List<Song>();
            list3.Add(new Song() { SongId = 1, Title = "Punky", Duration = 3.5M, Genre = "Hip Hop" });
            list3.Add(new Song() { SongId = 2, Title = "Cool", Duration = 3.5M, Genre = "Funk" });


            var artist3 = new Artist()
            {
                ArtistId = 3,
                Name = "Peter",
                Age = 27,
                Band="Whame",
                Songs = list3
            };
            ctx.Artist.Add(artist1);
            ctx.Artist.Add(artist2);
            ctx.Artist.Add(artist3);
            ctx.SaveChanges();


        }
    }
}