using System;
using System.Linq;

namespace RecursionAlgorhitms
{
    class Program
    {
        static int Sum(int[] arr, int index)
        {
            if(index == arr.Length)
            {
                return 0;
            }

            return arr[index] + Sum(arr, index + 1);
        }

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = Sum(arr, 0);

            Console.WriteLine(result);
        }
    }
}
