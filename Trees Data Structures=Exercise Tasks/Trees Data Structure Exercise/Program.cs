namespace Trees_Data_Structure_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static Dictionary<int, Tree<int>> tree
                             = new Dictionary<int, Tree<int>>();
        static void Main(string[] args)
        {
            int numberOfNodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNodes; i++)
            {
                string currentNode = Console.ReadLine();

                int[] currentValues = currentNode
                    .Split(' ').Select(n=> int.Parse(n)).ToArray();

                ;
            }

        }
    }

    public class Tree<T>
    {
        public T value;
        public List<Tree<T>> Children { get; set; }

        public List<Tree<T>> Parent { get; set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;
            this.Children = new List<Tree<T>>(children);
        }

    }

}
