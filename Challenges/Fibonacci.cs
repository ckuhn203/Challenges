using System;
using System.Collections.Generic;
using System.Numerics;

namespace Challenges
{
    class Fibonacci
    {
        private Dictionary<int, BigInteger> dictionary;

        public Fibonacci()
        {
            dictionary = new Dictionary<int, BigInteger>();
        }

        public BigInteger Calculate(int ordinalPosition)
        {
            BigInteger returnValue;
            BigInteger previous1;
            BigInteger previous2;

            //first try to get it from the dictionary
            if (dictionary.TryGetValue(ordinalPosition, out returnValue))
            {
                return returnValue;
            }

            // Fn where n < 0 doesn't make sense
            if (ordinalPosition < 0)
            {
                throw new ArgumentOutOfRangeException("OrdinalPosition", "Can't calculate Fn when n is less than zero.");
            }

            //Handle special cases of n == 0,1, or 2 (Priming the function).
            if (ordinalPosition == 0)
            {
                dictionary.Add(ordinalPosition, 0);
                return 0;
            }

            if (ordinalPosition == 1 || ordinalPosition == 2)
            {
                dictionary.Add(ordinalPosition, 1);
                return 1;
            }

            //If we already have the previous ordinalPosition, use that value to calculate the next.
            if (dictionary.TryGetValue(ordinalPosition - 1, out previous1))
            {
                dictionary.TryGetValue(ordinalPosition - 2, out previous2); //It's safe to assume if we found n-1, n-2 is there.
                returnValue = previous1 + previous2;
                dictionary.Add(ordinalPosition, returnValue);
                return returnValue;
            }

            //If we've gotten here, there's a gap between the last ordinalPosition and the one requested.
            if (dictionary.Count > 2)
            {
                //start at the next missing fibonacci number
                for (int i = dictionary.Count; i <= ordinalPosition; i++)
                {
                    dictionary.TryGetValue(dictionary.Count - 1, out previous1);
                    dictionary.TryGetValue(dictionary.Count - 2, out previous2);
                    returnValue = previous1 + previous2;
                    dictionary.Add(i, returnValue);
                }
                return returnValue;
            }

            //If all else fails, start at the beginning.
            Fibonacci fib = new Fibonacci();
            for (int i = 0; i <= ordinalPosition; i++)
            {
                dictionary.Add(i, fib.Calculate(i));
            }
            dictionary.TryGetValue(ordinalPosition, out returnValue);
            return returnValue;
        }
    }
}
