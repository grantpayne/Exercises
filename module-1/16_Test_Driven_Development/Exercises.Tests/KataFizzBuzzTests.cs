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
            result = kataFizzBuzz.FizzBuzz(35);
            Assert.AreEqual("FizzBuzz", result);
            result = kataFizzBuzz.FizzBuzz(53);
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
            result = kataFizzBuzz.FizzBuzz(13);
            Assert.AreEqual("Fizz", result);
            result = kataFizzBuzz.FizzBuzz(31);
            Assert.AreEqual("Fizz", result);
            result = kataFizzBuzz.FizzBuzz(83);
            Assert.AreEqual("Fizz", result);

        }
        [TestMethod]
        public void FizzBuzzTestForBuzzCases()
        {
            KataFizzBuzz kataFizzBuzz = new KataFizzBuzz();
            string result;
            result = kataFizzBuzz.FizzBuzz(5);
            Assert.AreEqual("Buzz", result);
            result = kataFizzBuzz.FizzBuzz(10);
            Assert.AreEqual("Buzz", result);
            result = kataFizzBuzz.FizzBuzz(50);
            Assert.AreEqual("Buzz", result);
            result = kataFizzBuzz.FizzBuzz(100);
            Assert.AreEqual("Buzz", result);
            result = kataFizzBuzz.FizzBuzz(52);
            Assert.AreEqual("Buzz", result);
            result = kataFizzBuzz.FizzBuzz(59);
            Assert.AreEqual("Buzz", result);
            result = kataFizzBuzz.FizzBuzz(56);
            Assert.AreEqual("Buzz", result);

        }
        [TestMethod]
        public void FizzBuzzTestForOtherCases()
        {
            KataFizzBuzz kataFizzBuzz = new KataFizzBuzz();
            string result;
            result = kataFizzBuzz.FizzBuzz(1);
            Assert.AreEqual("1", result);
            result = kataFizzBuzz.FizzBuzz(8);
            Assert.AreEqual("8", result);
            result = kataFizzBuzz.FizzBuzz(49);
            Assert.AreEqual("49", result);
            result = kataFizzBuzz.FizzBuzz(98);
            Assert.AreEqual("98", result);
        }


    }
}
