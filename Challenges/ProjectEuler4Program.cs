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

            Console.WriteLine(PE4PalindromeNumber());
            
            Console.WriteLine();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static int PE4PalindromeNumber()
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

        public static bool IsLength3(int number)
        {
            return (number.ToString().Length == 3);
        }

    }
}
