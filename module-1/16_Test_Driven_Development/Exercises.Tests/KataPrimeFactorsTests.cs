using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Exercises.Tests
{
    [TestClass]
    public class KataPrimeFactorsTests
    {
        [TestMethod]
        public void TestThatClassInstantiates()
        {
            KataPrimeFactors kataPrimeFactors = new KataPrimeFactors();
            Assert.IsNotNull(kataPrimeFactors);
        }
        [TestMethod]
        public void FindPrimeFactorsTestFor2()
        {
            KataPrimeFactors kataPrimeFactors = new KataPrimeFactors();
            List<int> result = new List<int>();
            result = kataPrimeFactors.FindPrimeFactors(2);
            CollectionAssert.AreEquivalent(new List<int> { 2 }, result);
        }
        [TestMethod]
        public void FindPrimeFactorsTestFor3()
        {
            KataPrimeFactors kataPrimeFactors = new KataPrimeFactors();
            List<int> result = new List<int>();
            result = kataPrimeFactors.FindPrimeFactors(3);
            CollectionAssert.AreEquivalent(new List<int> { 3 }, result);
        }
        [TestMethod]
        public void FindPrimeFactorsTestFor1()
        {
            KataPrimeFactors kataPrimeFactors = new KataPrimeFactors();
            List<int> result = new List<int>();
            result = kataPrimeFactors.FindPrimeFactors(1);
            CollectionAssert.AreEquivalent(new List<int> { 1 }, result);
        }
    }
}
