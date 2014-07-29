using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public static class Numbers
    {
        public static bool IsPrime(Int64 number)
        {
            if (number == 2)
            {
                return true;
            }

            if ((number < 2) || (number % 2 == 0))
            {
                return false;
            }
            
            double sqrtOfNumber = Math.Sqrt(number);

            for (var index = 3; index <= sqrtOfNumber; index += 2) //skip even numbers 
            {
                if (IsFactor(number,index) )
                {
                    return false;
                }
            }

            return true;

        }

        public static bool IsFactor(Int64 dividend, Int64 divisor)
        {
            return (dividend % divisor == 0);
        }

        public static Int64[] PrimeFactors(Int64 number)
        {
            var results = new List<Int64>();

            Int64 maxDivisor = number / 2;
            for (Int64 divisor = 2; divisor < maxDivisor; divisor++)
            {
                if (!(IsFactor(number, divisor) && IsPrime(divisor)))
                {
                    continue;
                }

                results.Add(divisor);

                Int64 factor = number / divisor;
                if (IsPrime(factor))
                {
                    results.Add(factor);
                }
                else
                {
                    results.AddRange(PrimeFactors(factor));
                }

                break;
            }

            return results.ToArray();
        }

        public static bool IsPalindrome(long number)
        {
            char[] digits = number.ToString().ToCharArray();
            
            for (var i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
