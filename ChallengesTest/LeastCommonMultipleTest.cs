using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class LeastCommonMultipleTest
    {
        [TestMethod]
        public void PositiveTest()
        {
            Assert.AreEqual(42, MathExtensions.LeastCommonMultiple(21, 6));
        }

        [TestMethod]
        public void ArrayMethodTest()
        {
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            Assert.AreEqual(2520, MathExtensions.LeastCommonMultiple(numbers),"Failed on Array of 10");

            numbers = Enumerable.Range(1, 20).ToArray();
            Assert.AreEqual(232792560, MathExtensions.LeastCommonMultiple(numbers), "Failed on Array of 20");
        }
    }
}
