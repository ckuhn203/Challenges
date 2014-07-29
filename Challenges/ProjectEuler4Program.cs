using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class ProjectEuler4Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> products = ListOfProducts();
            foreach (int product in products)
            {
                Console.WriteLine(product);
            }
             */
            
            Console.WriteLine("Find the largest palindrome made from the product of two 3-digit numbers.");

            bool foundIt = false;
            for (var i = 998001; i > 0 && !foundIt; i-- )
            {
                if (Numbers.IsPalindrome(i))
                {
                    for (var j = 999; j >= 100; j--)
                    {
                        if (Numbers.IsFactor(i,j))
                        {
                            if (IsLength3(i/j))
                            {
                                Console.WriteLine(i);
                                foundIt = true;
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(i);
            
            Console.WriteLine();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static bool IsLength3(int number)
        {
            return (number.ToString().Length == 3);
        }

        public int PE4PalindromeNumber()
        {
            for (var i = 998001; i > 0; i--)
            {
                if (Numbers.IsPalindrome(i))
                {
                    for (var j = 999; j >= 100; j--)
                    {
                        if (Numbers.IsFactor(i, j) && IsLength3(i/j))
                        {
                            return i;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
