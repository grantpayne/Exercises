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
        [TestMethod]
        public void FizzBuzzTestForFizzBuzzCases()
        {
            KataFizzBuzz kataFizzBuzz = new KataFizzBuzz();
            string result;
            result = kataFizzBuzz.FizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result);
            result = kataFizzBuzz.FizzBuzz(60);
            Assert.AreEqual("FizzBuzz", result);
            result = kataFizzBuzz.FizzBuzz(90);
            Assert.AreEqual("FizzBuzz", result);
        }
        [TestMethod]
        public void FizzBuzzTestForFizzCases()
        {
            KataFizzBuzz kataFizzBuzz = new KataFizzBuzz();
            string result;
            result = kataFizzBuzz.FizzBuzz(3);
            Assert.AreEqual("Fizz", result);
            result = kataFizzBuzz.FizzBuzz(6);
            Assert.AreEqual("Fizz", result);
            result = kataFizzBuzz.FizzBuzz(66);
            Assert.AreEqual("Fizz", result);
            result = kataFizzBuzz.FizzBuzz(99);
            Assert.AreEqual("Fizz", result);
        }


    }
}
