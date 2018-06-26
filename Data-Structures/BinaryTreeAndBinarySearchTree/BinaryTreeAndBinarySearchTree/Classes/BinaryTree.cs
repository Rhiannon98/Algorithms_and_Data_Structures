using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeAndBinarySearchTree.Classes
{
    class BinaryTree
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

            if(node.RightChild != null){PreOrder(node.RightChild);}
        }

        /// <summary>
        /// This one's pattern is Left, Root, Right in the pattern
        /// This iterates until the right most leaf is reached
        /// </summary>
        /// <param name="node">starting node, normally the root</param>
        public void InOrder(Node node)
        {
            if(node.LeftChild != null){InOrder(node.LeftChild);}

            if (node.RightChild != null){InOrder(node.RightChild);}
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
        }

        /// <summary>
        /// Searches tree using Breadth Approach to find desired value
        /// Big(O) is O(n) for both Time and Space
        /// </summary>
        /// <param name="root"></param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root)) {
                Node front = breadth.Dequeue();

                if(front.LeftChild != null){breadth.Enqueue(front.LeftChild);}

                if(front.RightChild != null){breadth.Enqueue(front.RightChild);}
        
            }
        }

        /// <summary>
        /// Traverses the tree starting at the root with a breadth approach
        /// This finds that desired value
        /// Big(O) is O(n) for both Time and Space
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

                if (front.Value == value) {return front;}

                if (front.LeftChild != null){breadth.Enqueue(front.LeftChild);}

                if(front.RightChild != null){breadth.Enqueue(front.RightChild);}
            }
            return null;
        }
    }
}
