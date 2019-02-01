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
        }

    }
}
