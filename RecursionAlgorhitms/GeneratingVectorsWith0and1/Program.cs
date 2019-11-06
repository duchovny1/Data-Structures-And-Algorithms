using System;

namespace GeneratingVectorsWith0and1
{
    class Program
    {
        private static void GenerateVectors(int[] array, int index)
        {
            if (index > array.Length - 1)
            {
                Console.WriteLine(string.Join("", array));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                array[index] = i;
                GenerateVectors(array, index + 1);
            }

        }


        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            GenerateVectors(arr, 0);
        }
    }
}
