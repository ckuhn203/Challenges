using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace ChallengesTest
{
    [TestClass]
    public class IsPrimeTest
    {
        [TestMethod]
        public void SmallPrimes()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            AssertTrue(numbers);
            
        }

        [TestMethod]
        public void NegativePrimelike()
        {
            int[] numbers = { -2, -3, -5, -7, -11, -13, -17, -19, -23, -29 };

            AssertFalse(numbers);
        }

        [TestMethod]
        public void NegativeNotPrimelike()
        {
            int[] numbers = { -4, -6, -8, -9, -10, -12, -14, -15, -16, -18, -20, -21, -22, -24, -25 };

            AssertFalse(numbers);
        }

        [TestMethod]
        public void PositiveNotPrime()
        {
            int[] numbers = { 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25 };

            AssertFalse(numbers);
        }

        [TestMethod]
        public void ZeroAndOne()
        {
            int[] numbers = { 0, 1 };

            AssertFalse(numbers);
        }

        [TestMethod]
        public void BigPrimes()
        {
            int[] numbers = {104677,104681, 104683, 104693, 104701, 104707, 104711, 104717, 104723, 104729 };

            AssertTrue(numbers);
        }

        [TestMethod]
        public void BigNotPrimes()
        {
            int[] numbers = { 104679, 104682, 104697, 104703, 104713 };

            AssertFalse(numbers);
        }

        private void AssertTrue(int[] integers)
        {
            for (var i = 0; i < integers.Length; i++)
            {
                Assert.IsTrue(Numbers.IsPrime(integers[i]), "Failed for {0}", i);
            }
        }

        private void AssertFalse(int[] integers)
        {
            for (var i = 0; i < integers.Length; i++)
            {
                Assert.IsFalse(Numbers.IsPrime(integers[i]), "Failed for {0}", i);
            }

        }
    }
}
