using BinaryTreeAndBinarySearchTree.Classes;
using System;

namespace BinaryTreeAndBinarySearchTree
{
    class Program
    {
        // this main class is heavily based off of Eric Singleton's 
        // using Eric's as a reference for the invokcation
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree(new Node(2));
            binaryTree.Add(new Node(3), binaryTree.Root);
            binaryTree.Add(new Node(5), binaryTree.Root);
            binaryTree.Add(new Node(7), binaryTree.Root);
            binaryTree.Add(new Node(11), binaryTree.Root);

            BinarySearchTree bst = new BinarySearchTree(new Node(577));
            bst.Add(new Node(587), bst.Root);
            bst.Add(new Node (593), bst.Root);
            bst.Add(new Node(599), bst.Root);
            bst.Add(new Node (601), bst.Root);

            Console.WriteLine("BreadthFirst:");
            binaryTree.BreadthFirst(binaryTree.Root);
            Console.WriteLine("------");
            bst.BreadthFirst(bst.Root);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("PreOrder:");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine("------");
            bst.PreOrder(bst.Root);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("InOrder:");
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine("------");
            bst.InOrder(bst.Root);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("PostOrder:");
            binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine("------");
            bst.PostOrder(bst.Root);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
