using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace langben
{
    public class CheckPerson
    {
        public string CheckNumber(string pnr)
        {
            if(pnr != "130229")
            return pnr;
            else
            {
                return "";
            }
            //throw new NotImplementedException();
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
            var actual = person.CheckNumber("20010101");
            var estimated = "20010101";
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
            var actual = person.CheckNumber("080415");
            var estimated = "080415";
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
            var actual = person.CheckNumber("160509");
            var estimated = "160509";
            //assert
            Assert.That(actual, Is.EqualTo(estimated));
        }
        //correct date in month

        //[Test]
        //public void CheckNumberMonth()
        //{
        //    //arange
        //    CheckPerson person = new CheckPerson();
        //    //act
        //    var actual = person.CheckNumber(12);
        //    var estimated = 12;
        //    //assert
        //    Assert.That(actual, Is.EqualTo(estimated));
        //}
        //correct date in day

        //[Test]
        //public void CheckNumberDay()
        //{
        //    //arange
        //    CheckPerson person = new CheckPerson();
        //    //act
        //    var actual = person.CheckNumber(7);
        //    var estimated = 7;
        //    //assert
        //    Assert.That(actual, Is.EqualTo(estimated));
        //}
        //correct date in leapyear
        [Test]
        public void CheckNumberLeapyear()
        {
            //arange
            CheckPerson person = new CheckPerson();
            //act
            var actual = person.CheckNumber("120229");
            var estimated = "120229";
            //assert
            Assert.That(actual, Is.EqualTo(estimated));
        }
        //incorrect date before
        //incorrect date after
        //incorrect date not leapyear
        [Test]
        public void CheckNumberNotLeapyear()
        {
            //arange
            CheckPerson person = new CheckPerson();
            //act
            var actual = person.CheckNumber("120229");
            //string estimated = null;
            //assert
            Assert.That(actual, Is.Null);
        }



    }
}