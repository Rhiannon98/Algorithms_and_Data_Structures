using System;

namespace KthElementFromEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kth Element from End! Whoop!");
            Console.WriteLine("Now, pick a number and see if this works!");
            int k = int.Parse(Console.ReadLine());
            int theK = KthElement(k).Value;
            Console.WriteLine(theK);
            Console.ReadKey();
        }
        public static Node KthElement(int k)
        {
            LinkdList LL = new LinkdList(new Node(2));
            LL.Add(new Node (3));
            LL.Add(new Node (5));
            LL.Add(new Node (7));
            LL.Add(new Node (11));
            LL.Add(new Node (13));
            LL.Add(new Node (17));
            LL.Add(new Node (19));
            LL.Add(new Node (23));
            LL.Add(new Node (29));
            LL.Add(new Node (31));
            LL.Add(new Node (37));
            LL.Add(new Node (41));
            LL.Add(new Node (43));
            LL.Add(new Node (47));

            LL.Print();

            LL.Current = LL.Head;
            Node Runner = LL.Head;
            int counter = 0;
            while (Runner.Next != null)
            {
                counter++;
                Runner = Runner.Next;
                if (counter > k)
                {
                    LL.Current = LL.Current.Next;
                }
            }
            return LL.Current;
        }
    }
}
