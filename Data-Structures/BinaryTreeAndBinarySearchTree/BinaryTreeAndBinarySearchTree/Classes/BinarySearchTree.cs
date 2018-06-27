using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeAndBinarySearchTree.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(Node node) : base(node) {Root = node;}

        /// <summary>
        /// Override from BinaryTree class to fit the BinarySearchTree
        /// </summary>
        /// <param name="node">node to be added</param>
        /// <param name="reference">end of a leaf to add node</param>
        public override void Add(Node node, Node reference)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(reference);

            while (breadth.TryPeek(out reference))
            {
                Node front = breadth.Dequeue();

                if (front.LeftChild == null && node.Value < front.Value)
                {
                    front.LeftChild = node;
                    return;
                }
                else if (front.RightChild == null && node.Value > front.Value)
                {
                    front.RightChild = node;
                    return;
                }
                if(front.LeftChild != null && node.Value < front.Value)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if(front.RightChild != null && node.Value > front.Value)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        /// <summary>
        /// An override and refactor of the BinaryTree Search method
        /// Follows a binary search pattern
        /// Big(O) = 0(log^n) ; each direction cuts the traversal time 
        /// in a logarithmic fashion
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="value">value to be found</param>
        /// <returns></returns>
        public override Node Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if(front.Value == value) {return front;}
                if (front.LeftChild != null && value < front.Value)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if(front.RightChild != null && value > front.Value)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return null;
        }
    }
}
