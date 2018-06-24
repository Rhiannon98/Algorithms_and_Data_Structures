using System;
using System.Collections.Generic;
using System.Text;

namespace StacksNQueues
{
    class Queue
    {
        // front of the queue
        public Node Front { get; set; }
        // back/end/rear of the queue
        public Node Rear { get; set; }
        // making said queue
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }
        /// <summary>
        /// will add a node to the rear
        /// </summary>
        /// <param name="newNode">node wanting to add</param>
        /// <returns></returns>
        public Node Enqueue(Node newNode)
        {
            Console.WriteLine($"Adding {newNode.Value} to the queue.");
            Rear.Next = newNode;
            Rear = newNode;
            return Rear;
        }
        /// <summary>
        /// removes from the queue
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            Console.WriteLine($"Removing {Front.Value} from the queue.");
            Node tmp = Front;
            Front = Front.Next;
            tmp.Next = null;
            return tmp;
        }
        /// <summary>
        /// peeks at the front of the queue
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Front;
        }
        /// <summary>
        /// displays all nodes in a queue
        /// </summary>
        public void Print()
        {
            Node Current = Front;
            Console.Write("Front ---> ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} ---> Rear");
            Console.WriteLine();
        }
    }
}
