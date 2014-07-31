using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class GreatestCommonDivisorTest
    {
        [TestMethod]
        public void PositiveLargestFirst()
        {
            Assert.AreEqual(6, MathExtensions.GreatestCommonDivisor(54, 24));
        }

        [TestMethod]
        public void PositiveSmallestFirst()
        {
            Assert.AreEqual(6, MathExtensions.GreatestCommonDivisor(24, 54));
        }

        [TestMethod]
        public void ZeroLast()
        {
            Assert.AreEqual(4, MathExtensions.GreatestCommonDivisor(4, 0));
        }

        [TestMethod]
        public void ZeroFirst()
        {
            Assert.AreEqual(4, MathExtensions.GreatestCommonDivisor(0, 4));
        }


    }
}
