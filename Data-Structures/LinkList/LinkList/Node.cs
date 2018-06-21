using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    /// <summary>
    /// Node is now accessible as a thing in
    /// and of itself to other documents.
    /// The Node requires 2 things in order to properly function
    /// </summary>
    /// <param ref="Value">The value the node will have</param>
    /// <param ref="Next">node that said node will point to, default = null</param>
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            // setting this to null = default node 
            Next = null;
        }
    }
}
