using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void IsItTheSameTestEmptyArray()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            Assert.IsNotNull(sameFirstLast);
            bool result = sameFirstLast.IsItTheSame(new int[] { });
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void IsItTheSameTestLengthOneArray()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            Assert.IsNotNull(sameFirstLast);
            bool result = sameFirstLast.IsItTheSame(new int[] { 1 });
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsItTheSameTestLengthTwoArrayUnequal()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            Assert.IsNotNull(sameFirstLast);
            bool result = sameFirstLast.IsItTheSame(new int[] { 0, 1});
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void IsItTheSameTestLengthTwoArrayEqual()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            Assert.IsNotNull(sameFirstLast);
            bool result = sameFirstLast.IsItTheSame(new int[] { 6, 6 });
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsItTheSameTestLongerArrayEqual()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            Assert.IsNotNull(sameFirstLast);
            bool result = sameFirstLast.IsItTheSame(new int[] { 6, 1, -123123124, -2, 0, 3, 76, 435, 6 });
            Assert.AreEqual(true, result);
        }
        public void IsItTheSameTestLongerArrayUnequal()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            Assert.IsNotNull(sameFirstLast);
            bool result = sameFirstLast.IsItTheSame(new int[] { 100, 6, 1, -123123124, -2, 0, 3, 76, 435, 6 });
            Assert.AreEqual(true, result);
        }
    }
}