using System;

namespace StacksNQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n We are gonna have some fun making a Queue first \n then we will make a dope stack fam\n");
            QueuePlay();
            StackPlay();
            Console.WriteLine("\nAlright, that's all I got");
            Console.ReadKey();
        }
        // will be testing enQ and DQ
        static void QueuePlay()
        {
            Queue newQ = new Queue(new Node(2));
            newQ.Enqueue(new Node(3));
            newQ.Enqueue(new Node(5));
            newQ.Enqueue(new Node(7));
            newQ.Enqueue(new Node(11));
            Console.WriteLine("Look at that queue!!\n");
            newQ.Print();

            Console.WriteLine("\nLets rid of that pesky 2\n");
            newQ.Dequeue();
            newQ.Print();
            Console.WriteLine("\nHah! What are the ODDS??\n");
        }
        static void StackPlay()
        {
            Stack newS = new Stack(new Node(4));
            newS.Push(new Node(6));
            newS.Push(new Node(8));
            newS.Push(new Node(10));
            newS.Push(new Node(1));
            Console.WriteLine("Mm mmm take a look at this stack!\n");
            newS.Print();

            Console.WriteLine("\nLets rid that odd 1 out\n");
            newS.Pop();
            newS.Print();
            Console.WriteLine("\nBam! Even Steven");
        }
    }
}
