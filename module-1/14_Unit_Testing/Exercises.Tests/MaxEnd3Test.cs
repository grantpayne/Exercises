using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void MakeArrayTestSetToLeft()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            Assert.IsNotNull(maxEnd3);
            int[] result = maxEnd3.MakeArray(new int[] { 9, 1, 5 });
            CollectionAssert.AreEqual(new int[] { 9, 9, 9 }, result);
        }

        [TestMethod]
        public void MakeArrayTestSetToRight()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            Assert.IsNotNull(maxEnd3);
            int[] result = maxEnd3.MakeArray(new int[] { 6, 7, 8 });
            CollectionAssert.AreEqual(new int[] { 8, 8, 8 }, result);
        }

        [TestMethod]
        public void MakeArrayTestMiddleIsGreatest()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            Assert.IsNotNull(maxEnd3);
            int[] result = maxEnd3.MakeArray(new int[] { 6, 7, 4 });
            CollectionAssert.AreEqual(new int[] { 6, 6, 6 }, result);
        }

        [TestMethod]
        public void MakeArrayTestLeftRightEven()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            Assert.IsNotNull(maxEnd3);
            int[] result = maxEnd3.MakeArray(new int[] { 2, 1, 2 });
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, result);
        }

        [TestMethod]
        public void MakeArrayTestNegatives()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            Assert.IsNotNull(maxEnd3);
            int[] result = maxEnd3.MakeArray(new int[] { -1, 0, -2 });
            CollectionAssert.AreEqual(new int[] { -1, -1, -1 }, result);
        }
    }
}
