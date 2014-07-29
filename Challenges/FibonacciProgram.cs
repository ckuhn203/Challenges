using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Challenges
{
    class FibonacciProgram
    {
         static void Main(string[] args)
        {
             Console.WriteLine("How many Fibonacci numbers should I print?");

             int input;
             if (int.TryParse(Console.ReadLine(),out input))
             {
                 WriteOkMesage();
                 WriteLotsOfFibonacci(input);   
             }
             else
             {
                 WriteNotAnIntegerMessage();
             }

            Console.WriteLine(Environment.NewLine + "Let's just pick one at random.");
            Console.WriteLine("What nth number Fibonacci would you like?");
           
            if (int.TryParse(Console.ReadLine(),out input))
            {
                WriteOkMesage();
                WriteAFibonacci(input);
            }
            else
            {
                WriteNotAnIntegerMessage();
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        static private void WriteAFibonacci(int n)
        {
            try
            {
                Fibonacci fib = new Fibonacci();
                Console.WriteLine("The answer is: " + fib.Calculate(n));
            }
            catch(ArgumentOutOfRangeException e)
            {
                WriteErrorMessage(e);
            }
        }

        static private void WriteLotsOfFibonacci(int numberToPrint)
        {
            Fibonacci fib = new Fibonacci();
            try
            {
                for (int i = 1; i <= numberToPrint; i++)
                {
                    Console.WriteLine(fib.Calculate(i));
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteErrorMessage(e);
            }
        }

        static private void WriteOkMesage()
        {
            Console.WriteLine("Okay!" + Environment.NewLine);
        }

        static private void WriteErrorMessage(Exception e)
        {
            Console.WriteLine(e.Source + " " + e.Message);
        }

        static private void WriteNotAnIntegerMessage()
        {
            Console.WriteLine("That's not an integer! I can't process that.");
        }

    }
}
