using System;

namespace TreeData
{
    public class BinaryTree<T>
    {
        public T Value { get; private set; }

        public BinaryTree<T> LeftChild { get; private set; }

        public BinaryTree<T> RightChild { get; private set; }

        public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public void PrintIndentedPreOrder(BinaryTree<T> node, int indent = 0)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(new string(' ', indent) + node.Value);
            PrintIndentedPreOrder(node.LeftChild, indent + 2);
            PrintIndentedPreOrder(node.RightChild, indent + 2);

        }

        public void EachInOrder(BinaryTree<T> node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            EachInOrder(node.LeftChild, action);
            action(node.Value);
            EachInOrder(node.RightChild, action);
        }

        public void EachPostOrder(BinaryTree<T> node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            EachPostOrder(node.LeftChild, action);
            EachPostOrder(node.RightChild, action);
            action(node.Value);
        }



    }
}
