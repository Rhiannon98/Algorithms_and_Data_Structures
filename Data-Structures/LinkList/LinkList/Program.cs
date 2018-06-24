using System;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Link List Implementation! Enjoy the show ;)");
            LinkListTest();
            Console.WriteLine("Thanks for watching me create a PRIME list! hehee");
        }
        static void LinkListTest()
        {
            LinkdList LL = new LinkdList(new Node(13));
            // testing add
            LL.Add(new Node(17));
            LL.Add(new Node(19));
            // list that we have so far, testing Print
            Console.WriteLine("What we got to work with so far");
            LL.Print();
            // testing find
            Node findNode = LL.Find(17);
            Console.WriteLine($"I asked...&& Look what I have found! Node value {findNode.Value}!!");
            // testing our addBefore
            LL.AddBefore(new Node(23), new Node(19));
            LL.Print();
            Console.WriteLine("We added a node before node.value 19");
            // testing addAfter
            LL.AddAfter(new Node(29), new Node(19));
            LL.Print();
            Console.WriteLine("We added a node after node.value 19");
            // test addLast
            LL.AddLast(new Node(199));
            LL.Print();
            Console.WriteLine("Look! We added a node to the end!!");
        }
    }
}
