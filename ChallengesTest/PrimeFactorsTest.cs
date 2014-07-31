using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class FactorsTest
    {
        [TestMethod]
        public void PrimeFactorsTest()
        {
            Int64[] expected = {5,7,13,29};
            Int64[] actual = MathExtensions.PrimeFactors(13195);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
