using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class ProjectEuler5Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LcmOfNumbersLessThan(10));
            Console.WriteLine(LcmOfNumbersLessThan(20));

            Console.WriteLine();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        private static long LcmOfNumbersLessThan(int number)
        {

            int result = 1;
            for (var i = 2; i < number; i++)
            {
                result = MathExtensions.LeastCommonMultiple(i, result);
            }
            return result;
        }
    }
}
