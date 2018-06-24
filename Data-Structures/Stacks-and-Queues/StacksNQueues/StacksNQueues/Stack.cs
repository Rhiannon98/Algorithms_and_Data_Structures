using System;
using System.Collections.Generic;
using System.Text;

namespace StacksNQueues
{
    class Stack
    {
        /// <summary>
        /// the top of a stack
        /// </summary>
        public Node Top { get; set; }
        /// <summary>
        /// constructor for a stack that requires a node
        /// </summary>
        /// <param name="node">the node to be put into the stack</param>
        public Stack(Node node)
        {
            Top = node;
        }
        /// <summary>
        /// pushes a node onto the top of the stack
        /// </summary>
        /// <param name="newNode"></param>
        public Node Push(Node newNode)
        {
            Console.WriteLine($"Adding {newNode.Value} to the stack");
            newNode.Next = Top;
            Top = newNode;
            return Top;
        }
        /// <summary>
        /// pops a node from the top of the stack
        /// </summary>
        /// <returns>the popped node</returns>
        public Node Pop()
        {
            Console.WriteLine($"Popping off {Top.Value} from the stack");
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }
        /// <summary>
        /// peek at the top node of a stack
        /// </summary>
        /// <returns>top node</returns>
        public Node Peek()
        {
            return Top;
        }
        /// <summary>
        /// displays all nodes in a stack
        /// </summary>
        public void Print()
        {
            Node Current = Top;
            Console.Write("TOP ---> ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} ---> NULL");
            Console.WriteLine();
        }
    }
}
