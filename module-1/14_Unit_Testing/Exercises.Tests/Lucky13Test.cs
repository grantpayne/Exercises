using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void GetLuckyTestEmptyInputArray()
        {
            Lucky13 lucky13 = new Lucky13();
            Assert.IsNotNull(lucky13);
            bool result = lucky13.GetLucky(new int[] { });
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetLuckyTestyOnlyThrees()
        {
            Lucky13 lucky13 = new Lucky13();
            Assert.IsNotNull(lucky13);
            bool result = lucky13.GetLucky(new int[] { 3, 3, 3});
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetLuckyTestOnlyOnes()
        {
            Lucky13 lucky13 = new Lucky13();
            Assert.IsNotNull(lucky13);
            bool result = lucky13.GetLucky(new int[] { 1 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetLuckyTestOnesAndThrees()
        {
            Lucky13 lucky13 = new Lucky13();
            Assert.IsNotNull(lucky13);
            bool result = lucky13.GetLucky(new int[] { 1, 3, 1, 3, 1, 3 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetLuckyTestNoOnesOrThrees()
        {
            Lucky13 lucky13 = new Lucky13();
            Assert.IsNotNull(lucky13);
            bool result = lucky13.GetLucky(new int[] { -10000, -23532, -3, -1, 0, 2, 4, 5, 6, 7, 8, 9 });
            Assert.AreEqual(true, result);
        }

    }
}

