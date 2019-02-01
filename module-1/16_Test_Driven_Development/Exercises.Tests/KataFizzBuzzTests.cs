using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void TestThatClassInstantiates()
        {
            KataFizzBuzz kataFizzBuzz = new KataFizzBuzz();
            Assert.IsNotNull(kataFizzBuzz);
        }
        [TestMethod]
        public void FizzBuzzTestValuesOutOfRange()
        {
            KataFizzBuzz kataFizzBuzz = new KataFizzBuzz();
            string result;
            result = kataFizzBuzz.FizzBuzz(0);
            Assert.AreEqual("", result);
            result = kataFizzBuzz.FizzBuzz(-35);
            Assert.AreEqual("", result);
            result = kataFizzBuzz.FizzBuzz(101);
            Assert.AreEqual("", result);
            result = kataFizzBuzz.FizzBuzz(43532534);
            Assert.AreEqual("", result);
        }
       
    }
}
