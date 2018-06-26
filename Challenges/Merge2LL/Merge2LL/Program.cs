using System;

namespace Merge2LL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merged 2 Link Lists");
            MergedLL().Print();
            Console.ReadKey();
        }
        public static LinkdList MergedLL()
        {
            LinkdList ll1 = new LinkdList(new Node(13));
            ll1.Add(new Node(3));
            ll1.Add(new Node(5));
            ll1.Add(new Node(7));
            ll1.Add(new Node(11));

            Console.WriteLine("Here is LL 1 :");
            ll1.Print();

            LinkdList ll2 = new LinkdList(new Node(2));
            ll2.Add(new Node(4));
            ll2.Add(new Node (6));
            ll2.Add(new Node (8));
            ll2.Add(new Node (10));

            Console.WriteLine("\nHere is LL 2 : ");
            ll2.Print();

            Console.WriteLine("\nbelow are the two merged!");
            ll1.MergeLL(ll1,ll2);

            return ll1;
        }
    }
}
