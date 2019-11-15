using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeData
{
    public class Tree<T>
    {
        public T value { get; set; }

        public IList<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;

            this.Children = new List<Tree<T>>();

            foreach (var child in children)
            {
                this.Children.Add(child);
            }
        }


        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.value);

            foreach (var child in this.Children)
            {
                child.Print(indent + 1);
            }
        }

        public void Each(Action<T> action)
        {
            action(this.value);
        }

        public IEnumerable<T> OrderDFS()
        {
            List<T> output = new List<T>();

            this.DFS(this, output);

            return output;
        }

        private void DFS(Tree<T> node, List<T> output)
        {
            foreach (var child in node.Children)
            {
                DFS(child, output);
            }

            output.Add(node.value);
        }

        public IEnumerable<T> OrderBFS()
        {
            List<T> tree = new List<T>();

            Queue<Tree<T>> outputTree = new Queue<Tree<T>>();

            outputTree.Enqueue(this);


            while (outputTree.Any())
            {
                Tree<T> currentValue = outputTree.Dequeue();
                tree.Add(currentValue.value);

                foreach (var child in currentValue.Children)
                {
                    outputTree.Enqueue(child);
                }
            }

            return tree;
        }


    }
}
