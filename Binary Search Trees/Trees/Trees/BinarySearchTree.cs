using System;
using System.Collections.Generic;

public class BinarySearchTree<T> where T : IComparable<T>
{
    public Node root;

    public class Node
    {
        public Node(T value)
        {
           this.Value = value;
        }

        public T Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }

    //public void Insert(T value)
    //{
    //    if(root == null)
    //    {
    //        Node node = new Node(value);
    //        this.root = node;
    //        return;
    //    }

    //    Node parent = null;
    //    Node current = this.root;

    //    while (current != null)
    //    {
    //        var direction = current.Value.CompareTo(value);

    //        if(direction > 0)
    //        {
    //            parent = current;
    //            current = current.Left;
    //        }
    //        else if(direction < 0)
    //        {
    //            parent = current;
    //            current = current.Right;
    //        }
    //        else
    //        {
    //            //if current.Value = value 
    //            return;
    //        }
    //    }

    //    Node newNode = new Node(value);

    //    if (parent.Value.CompareTo(value) > 0)
    //    {
    //        parent.Left = newNode;
    //    }
    //    else if (parent.Value.CompareTo(value) < 0)
    //    {
    //        parent.Right = newNode;
    //    }
        
    //}


    public Node Insert(Node node, T value)
    {
        if (node == null)
        {
            node = new Node(value);
            return node;
        }

        if (node.Value.CompareTo(value) > 0)
        {
            node.Left = Insert(node.Left, value);
        }
        else if (node.Value.CompareTo(value) < 0)
        {
            node.Right = Insert(node.Right, value);
        }


        return node;
    }

    public bool Contains(T value)
    {
        throw new NotImplementedException();
    }

    public void DeleteMin()
    {
        throw new NotImplementedException();
    }

    public BinarySearchTree<T> Search(T item)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> Range(T startRange, T endRange)
    {
        throw new NotImplementedException();
    }

    public void EachInOrder(Action<T> action)
    {
        throw new NotImplementedException();
    }
}

public class Launcher
{
    public static void Main(string[] args)
    {
        BinarySearchTree<int> binaryTree = new BinarySearchTree<int>();
        ;
    }
}


