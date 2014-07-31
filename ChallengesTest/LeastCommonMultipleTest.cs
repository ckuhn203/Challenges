using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class LeastCommonMultipleTest
    {
        [TestMethod]
        public void Positive()
        {
            Assert.AreEqual(42, MathExtensions.LeastCommonMultiple(21, 6));
        }
    }
}
