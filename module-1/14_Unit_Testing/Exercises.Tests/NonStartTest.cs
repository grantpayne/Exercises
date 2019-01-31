using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void GetPartialStringRegularCase()
        {
            NonStart nonStart = new NonStart();
            Assert.IsNotNull(nonStart);
            string result = nonStart.GetPartialString("Hello", "World");
            Assert.AreEqual("elloorld", result);
        }
        [TestMethod]
        public void GetPartialStringFirstStringEmpty()
        {
            NonStart nonStart = new NonStart();
            Assert.IsNotNull(nonStart);
            string result = nonStart.GetPartialString("", "World");
            Assert.AreEqual("orld", result);
        }
        [TestMethod]
        public void GetPartialStringSecondStringEmpty()
        {
            NonStart nonStart = new NonStart();
            Assert.IsNotNull(nonStart);
            string result = nonStart.GetPartialString("Hello", "");
            Assert.AreEqual("ello", result);
        }
        [TestMethod]
        public void GetPartialStringBothStringsEmpty()
        {
            NonStart nonStart = new NonStart();
            Assert.IsNotNull(nonStart);
            string result = nonStart.GetPartialString("", "");
            Assert.AreEqual("", result);
        }
    }
}
