using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class ProjectEuler3Program
    {
        static void Main(string[] args)
        {
            const Int64 verybigint = 600851475143;
            Int64[] factors = Numbers.PrimeFactors(verybigint);

            Console.WriteLine((factors.Max()));

            Console.WriteLine();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
