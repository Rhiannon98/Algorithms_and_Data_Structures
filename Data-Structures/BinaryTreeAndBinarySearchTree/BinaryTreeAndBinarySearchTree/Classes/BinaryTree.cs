using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeAndBinarySearchTree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// the beginning (root) of our tree
        /// </summary>
        /// <param name="node">1st/Starts node, being set to root</param>
        public BinaryTree(Node node){Root = node;}

        /// <summary>
        /// traverses the tree by a Root, Left, Right pattern
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(Node node)
        {
            if (node.LeftChild != null){PreOrder(node.LeftChild);}

            if (node.RightChild != null){PreOrder(node.RightChild);}

            Console.WriteLine(node.Value);
        }

        /// <summary>
        /// This one's pattern is Left, Root, Right in the pattern
        /// This iterates until the right most leaf is reached
        /// </summary>
        /// <param name="node">starting node, normally the root</param>
        public void InOrder(Node node)
        {
            if (node.LeftChild != null){InOrder(node.LeftChild);}

            if (node.RightChild != null){InOrder(node.RightChild);}

            Console.WriteLine(node.Value);
        }

        /// <summary>
        /// Traveres tree through a Left, Right, Root pattern
        /// Starts at the Left most leaf
        /// </summary>
        /// <param name="node">starting node, normally the root</param>
        public void PostOrder(Node node)
        {
            if(node.LeftChild != null){PostOrder(node.LeftChild);}

            if(node.RightChild != null){PostOrder(node.RightChild);}
                        
            Console.WriteLine(node.Value);
        }

        /// <summary>
        /// Searches tree using Breadth Approach to find desired value
        /// Big(O) is O(n) for both Time
        /// </summary>
        /// <param name="root"></param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root)) {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);

                if(front.LeftChild != null){breadth.Enqueue(front.LeftChild);}

                if(front.RightChild != null){breadth.Enqueue(front.RightChild);}
        
            }
        }

        /// <summary>
        /// Traverses the tree starting at the root with a breadth approach
        /// This finds that desired value
        /// Big(O) is O(n) for both Time 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual Node Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while(breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);

                if (front.Value == value) {return front;}

                if (front.LeftChild != null){breadth.Enqueue(front.LeftChild);}

                if(front.RightChild != null){breadth.Enqueue(front.RightChild);}
            }
            return null;
        }

        /// <summary>
        /// Method traversal through the tree starting at the root
        /// This method utilizes the breadth approach
        /// Approach runs until desired value is met
        /// </summary>
        /// <param name="node">node wanting to be added</param>
        /// <param name="root">most "root" node of tree</param>
        public virtual void Add(Node node, Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while(breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);

                if(front.LeftChild != null) {breadth.Enqueue(front.LeftChild);}
                if(front.RightChild != null) {breadth.Enqueue(front.RightChild);}

                if(front.LeftChild == null) 
                { 
                    front.LeftChild = node;
                    return;
                }
                else if(front.RightChild == null)
                {
                    front.RightChild = node;
                    return;
                }
            }
        }
    }
}
