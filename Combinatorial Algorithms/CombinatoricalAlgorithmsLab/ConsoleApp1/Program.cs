using System;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static int[] elements;
        static bool[] used;
        static int[] permute;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            used = new bool[elements.Length];
            permute = new int[elements.Length];


            PermuteWithRepetions(elements, 0, elements.Length - 1);
        }

        static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permute));
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        permute[index] = elements[i];
                        Permute(index + 1);
                        used[i] = false;
                    }
                }

            }
        }

        //Optimize permutations 
        static void SwapPermute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(String.Join(" ", elements));
            }
            else
            {
                SwapPermute(index + 1);
                for (int i = index + 1; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        Swap(index, i);
                        SwapPermute(index + 1);
                        Swap(index, i);
                    }
                }
            }
        }

        static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        static void PermuteWithRepetions(int[] arr, int start, int end)
        {
            Console.WriteLine(string.Join(" ", elements));
            for (int left = end - 1; left >= start; left--)
            {
                for (int right = left + 1; right <= end; right++)
                {
                    if(arr[left] != arr[right])
                    {
                        Swap(left, right);
                        PermuteWithRepetions(arr, left + 1, end);
                    }
                }
                var firstEl = arr[left];
                for (int i = left; i <= end - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[end] = firstEl;
            }

        }


    }
}
