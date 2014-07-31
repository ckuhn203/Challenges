using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class ProjectEuler6Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Enumerable.Range(1, 100).ToList();
            List<int> squares = new List<int>();

            foreach (var i in numbers)
            {
                squares.Add(i * i);
            }

            long numberSum = numbers.Sum();
            long temp = (numberSum * numberSum) - squares.Sum();
            Console.WriteLine(temp);

            Console.WriteLine();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }


    }
}
