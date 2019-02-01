using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        [TestMethod]
        public void TestForClassInstantiation()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            Assert.IsNotNull(kataRomanNumerals);
        }
        [TestMethod]
        public void ConvertToRomanNumeralTestOnes()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            string result = kataRomanNumerals.ConvertToRomanNumeral(1);
            Assert.AreEqual("I", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(2);
            Assert.AreEqual("II", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(3);
            Assert.AreEqual("III", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(4);
            Assert.AreEqual("IV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(5);
            Assert.AreEqual("V", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(6);
            Assert.AreEqual("VI", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(7);
            Assert.AreEqual("VII", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(8);
            Assert.AreEqual("VIII", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(9);
            Assert.AreEqual("IX", result);
        }

    }
}
