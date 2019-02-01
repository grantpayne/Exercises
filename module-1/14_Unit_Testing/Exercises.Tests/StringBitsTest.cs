using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void GetBitsTestEmptyString()
        {
            StringBits stringBits = new StringBits();
            Assert.IsNotNull(stringBits);
            string result = stringBits.GetBits("");
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void GetBitsTestStringLengthOne()
        {
            StringBits stringBits = new StringBits();
            Assert.IsNotNull(stringBits);
            string result = stringBits.GetBits("g");
            Assert.AreEqual("g", result);
        }
        [TestMethod]
        public void GetBitsTestStringLengthTwo()
        {
            StringBits stringBits = new StringBits();
            Assert.IsNotNull(stringBits);
            string result = stringBits.GetBits("Kd");
            Assert.AreEqual("K", result);
        }
        [TestMethod]
        public void GetBitsTestLongerString()
        {
            StringBits stringBits = new StringBits();
            Assert.IsNotNull(stringBits);
            string result = stringBits.GetBits("The Quick Brown Fox Jumps Over The Lazy Dog.");
            Assert.AreEqual("TeQikBonFxJmsOe h ayDg", result);
        }
    }
}
