using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEF.Models
{
    public class NinjaContext : DbContext
    {
        public NinjaContext() : base ("KampSport")
        {
            Database.SetInitializer<NinjaContext>(new NinjaInitializer());
        }
     
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Weapon> Weapons { get; set; }


    }

    public class NinjaInitializer : DropCreateDatabaseAlways<NinjaContext>
    {
        protected override void Seed(NinjaContext context)
        {
            var ninjas = new List<Ninja>()
            {
                new Ninja()
                {
                   NinjaId = 1, Name = "Scorpion", Age = 33, Level = 3
                },
                 new Ninja()
                {
                   NinjaId = 2, Name = "SubZero", Age = 42, Level = 1
                },
                  new Ninja()
                {
                   NinjaId = 3, Name = "Ken", Age = 24, Level = 2
                }
            };
            foreach (var ninja in ninjas)
            {
                context.Ninjas.Add(ninja);

            }
            context.SaveChanges();
            var weapons = new List<Weapon>()
            {
                new Weapon()
                {
                    WeaponId = 1, Name = "Sword", Speed = 10M, Weigth = 3.05M, Range = 1.20M
                },
                new Weapon()
                {
                    WeaponId = 2, Name = "War Hammer", Speed = 6.05M, Weigth = 13.05M, Range = 1.10M
                },new Weapon()
                {
                    WeaponId = 3, Name = "Spear", Speed = 10M, Weigth = 4.05M, Range = 1.90M
                }
            };
            foreach (var weapon in weapons)
            {
                context.Weapons.Add(weapon);
            }
            context.SaveChanges();
        }
    }
}