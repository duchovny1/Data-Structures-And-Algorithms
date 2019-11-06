using System;

namespace RecursiceFactorial
{
    class Program
    {

        static long Factorial(long num)
        {
            if (num <= 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(long.Parse(Console.ReadLine())));
        }
    }
}
