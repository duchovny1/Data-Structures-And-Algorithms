using System;
using System.Linq;

namespace ReverseArrayRecursively
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();


            ReverseArrayRecursively(arr, arr.Length - 1);

           
        }

        private static void ReverseArrayRecursively(int[] arr, int index)
        {
            if (index < 0)
            {
                return;
            }

            Console.Write(arr[index] + " ");
            ReverseArrayRecursively(arr, --index);
        }
    }
}
