using System;
using System.Linq;

namespace ConsoleApp1
{  
    public class Program
    {
        static string[] elements;
        static bool[] used;
        static string[] permute;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(" ").ToArray();
            used = new bool[elements.Length];
            permute = new string[elements.Length];


            PermuteWithReps(0);
        }

        static void Permute(int index)
        {
            if(index >= elements.Length)
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
                for (int i = index + i; i < elements.Length; i++)
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

        private static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}
