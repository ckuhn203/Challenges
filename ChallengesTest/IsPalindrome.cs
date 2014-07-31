using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class IsPalindrome
    {
        [TestMethod]
        public void IsPalindrome_10Power3_True()
        {
            Assert.IsTrue(MathExtensions.IsPalindrome(1001),"Failed on {0}",1001);
            Assert.IsTrue(MathExtensions.IsPalindrome(1991), "Failed on {0}", 1991);
        }

        [TestMethod]
        public void IsPalindromic_10Power3_False()
        {
            Assert.IsFalse(MathExtensions.IsPalindrome(1212), "Failed on {0}", 1212);
            Assert.IsFalse(MathExtensions.IsPalindrome(7589), "Failed on {0}", 7589);
        }

        [TestMethod]
        public void IsPalindromic_10Power4_False()
        {
            Assert.IsFalse(MathExtensions.IsPalindrome(75987), "Failed on {0}", 75897);
        }

        [TestMethod]
        public void IsPalindromic_10Power4_True()
        {
            Assert.IsTrue(MathExtensions.IsPalindrome(11511), "Failed on {0}", 11511);
        } 
    }
}
