using System;
using System.Collections.Generic;

public class BinarySearchTree<T> where T : IComparable<T>
{
    public Node root;

    private Node parent;

    public BinarySearchTree()
    {
            
    }

    public BinarySearchTree(Node root)
    {
        this.Copy(root);
    }

    private void Copy(Node root)
    {
        if (root == null)
        {
            return;
        }

        this.Insert(root.Value);
        this.Copy(root.Left);
        this.Copy(root.Right);
    }

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

    public void Insert(T value)
    {
        if (root == null)
        {
            Node node = new Node(value);
            this.root = node;
            return;
        }

        Node parent = null;
        Node current = this.root;

        while (current != null)
        {
            var direction = current.Value.CompareTo(value);

            if (direction > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if (direction < 0)
            {
                parent = current;
                current = current.Right;
            }
            else
            {
                //if current.Value = value 
                return;
            }
        }

        Node newNode = new Node(value);

        if (parent.Value.CompareTo(value) > 0)
        {
            parent.Left = newNode;
        }
        else if (parent.Value.CompareTo(value) < 0)
        {
            parent.Right = newNode;
        }

    }


    //public Node Insert(Node node, T value)
    //{
    //    if (node == null)
    //    {
    //        node = new Node(value);
    //        return node;
    //    }

    //    if (node.Value.CompareTo(value) > 0)
    //    {
    //        node.Left = Insert(node.Left, value);
    //    }
    //    else if (node.Value.CompareTo(value) < 0)
    //    {
    //        node.Right = Insert(node.Right, value);
    //    }


    //    return node;
    //}

    public bool Contains(T value)
    {
        Node currentNode = this.root;

        while(currentNode != null)
        {
            if (currentNode.Value.CompareTo(value) > 0)
            {
                currentNode = currentNode.Left;
            }
            else if(currentNode.Value.CompareTo(value) < 0)
            {
                currentNode = currentNode.Right;
            }
            else
            {
                return true;
            }
        }


        return false;
    }

    public void DeleteMin()
    {
        throw new NotImplementedException();
    }

    public BinarySearchTree<T> Search(T item)
    {
        var parent = this.root;

        if ((parent.Value.CompareTo(item)) == 0)
        {
            return new BinarySearchTree<T>(parent);
        }

        int compare = parent.Value.CompareTo(item);

        Node currentChild;

        if (compare > 0)
        {
            currentChild = parent.Left;
        }
        else //if(compare < 0)
        {
            currentChild = parent.Right;
        }

        while (currentChild != null)
        {
            compare = parent.Value.CompareTo(currentChild.Value);

            if (compare > 0)
            {
                parent = currentChild;
                currentChild = currentChild.Left;
            }
            else if(compare < 0)
            {
                parent = currentChild;
                currentChild = currentChild.Right;
            }
            else
            {
                
                return new BinarySearchTree<T>(currentChild);
            }
        }

        return new BinarySearchTree<T>();

    }

    public IEnumerable<T> Range(T startRange, T endRange)
    {
        throw new NotImplementedException();
    }

    public void EachInOrder(Action<T> action)
    {
        EachInOrder(this.root, action);
    }

    private void EachInOrder(Node currentNode, Action<T> action)
    {
        if(currentNode == null)
        {
            return;
        }

        EachInOrder(currentNode.Left, action);
        action(currentNode.Value);
        EachInOrder(currentNode.Right, action);
    }
}

public class Launcher
{
    public static void Main(string[] args)
    {
        BinarySearchTree<int> binaryTree = new BinarySearchTree<int>();

        binaryTree.Insert(18);
        binaryTree.Insert(13);
        binaryTree.Insert(7);
        binaryTree.Insert(15);
        binaryTree.Insert(24);
        binaryTree.Insert(20);
        binaryTree.Insert(28);
        binaryTree.Insert(14);

        BinarySearchTree<int> secondTree = binaryTree.Search(13);
        ;
      
    }
}


