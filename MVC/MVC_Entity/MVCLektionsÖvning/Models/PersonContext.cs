using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Entity.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base ("Choklad")
        {
            Database.SetInitializer<PersonContext>(new PersonInitialzer());
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Adress> Adresses { get; set; }


    }

    internal class PersonInitialzer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var Persons = new List<Person>()
            {
                new Person() {PersonId = 1, Name = "Youness Essadak", DateOfBirth = new DateTime(1979,04,07), Height = 179.00M, Weigth = 88.00M},
                new Person() {PersonId = 2, Name = "Nezar Essadak", DateOfBirth = new DateTime(2007,11,07), Height = 136.00M, Weigth = 40.00M},
                new Person() {PersonId = 3, Name = "Amanda Kinnander", DateOfBirth = new DateTime(1991,05,21), Height = 170.00M, Weigth = 70.00M},
            };
            foreach (var person in Persons)
            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
            var adresses = new List<Adress>()
            {
                new Adress() {AdressID = 1, Street = "Wienergatan 7", Zip = "252 28", City = "Helsingborg" },
                new Adress() {AdressID = 2, Street = "Lägevägen 15", Zip = "252 61", City = "Helsingborg" },
                new Adress() {AdressID = 3, Street = "Wienergatan 7", Zip = "252 28", City = "Helsingborg" },

            };
            foreach (var adress in adresses)
            {
                context.Adresses.Add(adress);
                context.SaveChanges();
            }
        }
    }
}