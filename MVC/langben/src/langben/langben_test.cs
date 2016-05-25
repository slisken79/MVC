using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace langben
{
    [TestFixture]
    public class langben_test
    {
        [Test]
        public void AddCorrectCalculation()
        {
            //Arange
            var expected = 5;
            //Act
            var actual = langben.Add(3, 2);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}
