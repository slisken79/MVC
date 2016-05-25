using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Add("0", "5");
            var expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddTestNull()
        {
            Calculator calculator2 = new Calculator();
            var actual = calculator2.Add("0", "0");
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddTestTwoParam()
        {
            Calculator calculator2 = new Calculator();
            var actual = calculator2.Add("1", "2");
            var expected = 12;
            Assert.AreEqual(expected, actual);
        }
    }
}