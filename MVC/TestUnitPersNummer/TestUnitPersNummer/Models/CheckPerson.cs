using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUnitPersNummer.Models
{
    public class CheckPerson
    {
        public long CheckNumber(long pnr)
        {
            return pnr;
            throw new NotImplementedException();
        }


    }
    [TestFixture]
    public class CheckPersonTest
    {
        //correct date in the biginning
        [Test]
        public void CheckNumberBeginning()
        {
            //arange
            CheckPerson person = new CheckPerson();
            //act
            var actual = person.CheckNumber(20010101);
            var estimated = 20010101;
            //assert
            Assert.That(actual, Is.EqualTo(estimated));
        }
        //correct date in middle
        [Test]
        public void CheckNumberMiddle()
        {
            //arange
            CheckPerson person = new CheckPerson();
            //act
            var actual = person.CheckNumber(0315);
            var estimated = 0315;
            //assert
            Assert.That(actual, Is.EqualTo(estimated));
        }
        //correct date in end
        [Test]
        public void CheckNumberEnd()
        {
            //arange
            CheckPerson person = new CheckPerson();
            //act
            var actual = person.CheckNumber(0101);
            var estimated = 0101;
            //assert
            Assert.That(actual, Is.EqualTo(estimated));
        }
        //correct date in month
    
        [Test]
        public void CheckNumberMonth()
        {
            //arange
            CheckPerson person = new CheckPerson();
            //act
            var actual = person.CheckNumber(12);
            var estimated = 12;
            //assert
            Assert.That(actual, Is.EqualTo(estimated));
        }
        //correct date in day

        [Test]
        public void CheckNumberDay()
        {
            //arange
            CheckPerson person = new CheckPerson();
            //act
            var actual = person.CheckNumber(7);
            var estimated = 7;
            //assert
            Assert.That(actual, Is.EqualTo(estimated));
        }
        //correct date in leapyear
        //incorrect date before
        //incorrect date after
        //incorrect date not leapyear



    }
}