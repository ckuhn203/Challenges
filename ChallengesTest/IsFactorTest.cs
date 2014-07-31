using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class IsFactorTest
    {
        [TestMethod]
        public void Test12True()
        {
            //2*2*3
            Assert.IsTrue(MathExtensions.IsFactor(12, 2));
            Assert.IsTrue(MathExtensions.IsFactor(12, 4));
            Assert.IsTrue(MathExtensions.IsFactor(12, 3));
            Assert.IsTrue(MathExtensions.IsFactor(12, 6));
        }

        [TestMethod]
        public void Test12False()
        {
            Assert.IsFalse(MathExtensions.IsFactor(12, 5));
            Assert.IsFalse(MathExtensions.IsFactor(12, 7));
            Assert.IsFalse(MathExtensions.IsFactor(12, 8));
            Assert.IsFalse(MathExtensions.IsFactor(12, 9));
        }

        /*
        [TestMethod]
        public void Test15()
        {
            //3*5

        }

        [TestMethod]
        public void Test120()
        {
            //2*3*4*5
        }
         */
    }
}
