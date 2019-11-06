using System;

namespace NestedLoopsWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];

            RecursiveNestedLoop(arr, number);
        }

        private static void RecursiveNestedLoop(int[] arr, int number)
        {
            if (arr.Length < 0)
            {
                return;
            }

            for (int i = 1; i <= number; i++)
            {
                arr[i - 1] = i;
                
            }

        }
    }
}
