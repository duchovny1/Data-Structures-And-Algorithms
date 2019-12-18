using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursions
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(1, 3);

            Stack<int> source = new Stack<int>(range.Reverse());
            Stack<int> destination = new Stack<int>();
            Stack<int> spare = new Stack<int>();

            TOH(source.Count, source, destination, spare);


            Console.WriteLine(string.Join(" ", destination));
        }

        private static void TOH(int count, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if(count == 1)
            {
                destination.Push(source.Pop());
                return;
            }

            TOH(count - 1, source, spare, destination);
            destination.Push(source.Pop());
            TOH(count - 1, spare, destination, source);
        }
    }
}
