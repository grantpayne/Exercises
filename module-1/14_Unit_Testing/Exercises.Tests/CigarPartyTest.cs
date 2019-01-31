using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void HavePartyTestWeekendHigh()
        {
            CigarParty cigarParty = new CigarParty();
            Assert.IsNotNull(cigarParty);
            bool result = cigarParty.HaveParty(80, true);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HavePartyTestWeekendMid()
        {
            CigarParty cigarParty = new CigarParty();
            Assert.IsNotNull(cigarParty);
            bool result = cigarParty.HaveParty(50, true);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HavePartyTestWeekendLow()
        {
            CigarParty cigarParty = new CigarParty();
            Assert.IsNotNull(cigarParty);
            bool result = cigarParty.HaveParty(0, true);
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void HavePartyTestWeekdayHigh()
        {
            CigarParty cigarParty = new CigarParty();
            Assert.IsNotNull(cigarParty);
            bool result = cigarParty.HaveParty(80, false);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void HavePartyTestWeekdayMid()
        {
            CigarParty cigarParty = new CigarParty();
            Assert.IsNotNull(cigarParty);
            bool result = cigarParty.HaveParty(50, false);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HavePartyTestWeekdayLow()
        {
            CigarParty cigarParty = new CigarParty();
            Assert.IsNotNull(cigarParty);
            bool result = cigarParty.HaveParty(0, false);
            Assert.AreEqual(false, result);
        }
    }
}

