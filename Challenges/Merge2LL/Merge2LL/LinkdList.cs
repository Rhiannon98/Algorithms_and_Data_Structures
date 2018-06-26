using System;
using System.Collections.Generic;
using System.Text;

namespace Merge2LL
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
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} --> NULL");
        }
        // find a node
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
        // add to end
        public void AddLast(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }
         public LinkdList MergeLL(LinkdList ll1, LinkdList ll2)
        {
            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;
            LinkdList ll3 = new LinkdList(new Node(ll1.Current.Value));
            int counter = 1;
            while (ll1.Current.Next != null && ll2.Current.Next != null)
            {
                if (ll1.Current.Next != null && counter % 2 == 0)
                {
                    ll1.Current = ll1.Current.Next;
                }
                if (ll2.Current.Next != null && counter % 2 != 0)
                {
                    ll1.AddAfter(new Node(ll2.Current.Value), new Node(ll1.Current.Value));
                    ll1.Current = ll1.Current.Next;
                    ll2.Current = ll2.Current.Next;
                }
                counter++;
            }
            while (ll2.Current != null)
            {
                ll1.AddLast(new Node(ll2.Current.Value));
                ll2.Current = ll2.Current.Next;
            }
            return ll1;
         }
    }
}
