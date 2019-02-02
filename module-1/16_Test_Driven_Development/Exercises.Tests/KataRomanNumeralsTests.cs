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
        [TestMethod]
        public void ConvertToRomanNumeralTestTens()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            string result = kataRomanNumerals.ConvertToRomanNumeral(10);
            Assert.AreEqual("X", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(11);
            Assert.AreEqual("XI", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(14);
            Assert.AreEqual("XIV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(19);
            Assert.AreEqual("XIX", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(20);
            Assert.AreEqual("XX", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(40);
            Assert.AreEqual("XL", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(90);
            Assert.AreEqual("XC", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(99);
            Assert.AreEqual("XCIX", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(44);
            Assert.AreEqual("XLIV", result);
        }
        [TestMethod]
        public void ConvertToRomanNumeralTestHundreds()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            string result = kataRomanNumerals.ConvertToRomanNumeral(100);
            Assert.AreEqual("C", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(104);
            Assert.AreEqual("CIV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(109);
            Assert.AreEqual("CIX", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(333);
            Assert.AreEqual("CCCXXXIII", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(444);
            Assert.AreEqual("CDXLIV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(449);
            Assert.AreEqual("CDXLIX", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(784);
            Assert.AreEqual("DCCLXXXIV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(894);
            Assert.AreEqual("DCCCXCIV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(999);
            Assert.AreEqual("CMXCIX", result);
        }
        [TestMethod]
        public void ConvertToRomanNumeralTestThousands()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            string result = kataRomanNumerals.ConvertToRomanNumeral(1000);
            Assert.AreEqual("M", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(1001);
            Assert.AreEqual("MI", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(1111);
            Assert.AreEqual("MCXI", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(1234);
            Assert.AreEqual("MCCXXXIV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(1444);
            Assert.AreEqual("MCDXLIV", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(1999);
            Assert.AreEqual("MCMXCIX", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(2399);
            Assert.AreEqual("MMCCCXCIX", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(2878);
            Assert.AreEqual("MMDCCCLXXVIII", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(3999);
            Assert.AreEqual("MMMCMXCIX", result);
        }
        [TestMethod]
        public void ConvertToRomanNumeralTestInputOutOfRange()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            string result = kataRomanNumerals.ConvertToRomanNumeral(-1);
            Assert.AreEqual("Value out of range - Please enter a number in the range 0-3999.", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(-234234);
            Assert.AreEqual("Value out of range - Please enter a number in the range 0-3999.", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(4000);
            Assert.AreEqual("Value out of range - Please enter a number in the range 0-3999.", result);
            result = kataRomanNumerals.ConvertToRomanNumeral(12423432);
            Assert.AreEqual("Value out of range - Please enter a number in the range 0-3999.", result);
        }

        [TestMethod]
        public void ConvertToDigitTestForEmptyStringInput()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            int result = kataRomanNumerals.ConvertToDigit("");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void ConvertToDigitTestGeneralInputs()
        {
            KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
            int resultNum = kataRomanNumerals.ConvertToDigit("I");
            Assert.AreEqual(1, resultNum);
            resultNum = kataRomanNumerals.ConvertToDigit("IV");
            Assert.AreEqual(4, resultNum);
            resultNum = kataRomanNumerals.ConvertToDigit("IX");
            Assert.AreEqual(9, resultNum);
            resultNum = kataRomanNumerals.ConvertToDigit("X");
            Assert.AreEqual(10, resultNum);
            resultNum = kataRomanNumerals.ConvertToDigit("XLIV");
            Assert.AreEqual(44, resultNum);
            resultNum = kataRomanNumerals.ConvertToDigit("CDXCIX");
            Assert.AreEqual(499, resultNum);
            resultNum = kataRomanNumerals.ConvertToDigit("MMMCMXCIX");
            Assert.AreEqual(3999, resultNum);
            resultNum = kataRomanNumerals.ConvertToDigit("MMCMXLII");
            Assert.AreEqual(2942, resultNum);
        }

    }
}
