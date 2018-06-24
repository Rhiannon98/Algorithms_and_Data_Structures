using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    public class LinkdList
    {
        /// <summary>
        /// Always points to the first node in a LL.
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// The node that is used to traverse through the LinkedList
        /// We can add another node and call it something else
        /// to traverse with the current if need be
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Requiring at least one node to be present for a LL to be created
        /// </summary>
        /// <param name="node"></param>
        public LinkdList(Node node)
        {
            Head = node;
            Current = node;
        }

        //Adding a Node O(1)

        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        // Print out Nodes O(n)

        public void Print()
        {
            // setting current to equal head in most of these problems to 
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} --> NULL");
        }

        /// <summary>
        /// Finds a node with a specified Value. 
        /// Big O of this is O(n)
        /// </summary>
        /// <param name="value">value to search</param>
        /// <returns>Node that contains the value</returns>
        public Node Find(int value)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }

            return Current.Value == value ? Current : null;
        }

        // Add Before O(n)

        public void AddBefore(Node newNode, Node existingNode)
        {
            //Reset our Current to the beginning of the Linked List
            // if we are not already there
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        // Add After O(n)
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;
          
            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }

                Current = Current.Next;
            }

        }


        // Add Last O(n)
        // this function will only add the new node 
        // but only after the end has been found
        public void AddLast(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
        }
    }
}
