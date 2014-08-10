using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Challenges
{
    class ProjectEuler7Program
    {
        static void Main(string[] args)
        {

            List<long> primes = new List<long>();
            long i = 1;

            while (primes.Count < 10001)
            {
                if (MathExtensions.IsPrime(i))
                {
                    primes.Add(i);
                }
                i++;
                    
            }

            Console.WriteLine(primes.Last());
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
