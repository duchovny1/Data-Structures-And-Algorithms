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


            Permute(0);
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
    }
}
