using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void GetCountTestEmptyArray()
        {
            WordCount wordCount = new WordCount();
            Assert.IsNotNull(wordCount);
            Dictionary<string, int> result = new Dictionary<string, int>();
            result = wordCount.GetCount(new string[] { });
            Dictionary<string, int> expected = new Dictionary<string, int>();
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetCountTestArrayContainingEmptyStrings()
        {
            WordCount wordCount = new WordCount();
            Assert.IsNotNull(wordCount);
            Dictionary<string, int> result = new Dictionary<string, int>();
            result = wordCount.GetCount(new string[] { "", "", ""});
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected.Add("", 3);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetCountTestRegularCase()
        {
            WordCount wordCount = new WordCount();
            Assert.IsNotNull(wordCount);
            Dictionary<string, int> result = new Dictionary<string, int>();
            result = wordCount.GetCount(new string[] { "I", "love", "love", "love", "unit", "tests!" });
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected.Add("I", 1);
            expected.Add("love", 3);
            expected.Add("unit", 1);
            expected.Add("tests!", 1);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
