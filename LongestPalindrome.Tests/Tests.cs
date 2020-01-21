using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestPalindrome.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow("abacab", "bacab")]
        public void Test(string input, string expected)
        {
            var sut = new Solution();
            var result = sut.LongestPalindrome(input);
            Assert.AreEqual(expected, result);
        }
    }
}
