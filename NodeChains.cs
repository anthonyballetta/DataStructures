using System;

namespace DataStructures
{

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // +-------+--------+
            // |   3   |  null  +
            // +-------+--------+
            // Node has value of 3 and a Next pointer of NULL
            Node first = new Node { Value = 3 };

            Node middle = new Node { Value = 5 };

            first.Next = middle;

            Node last = new Node { Value = 7 };

            middle.Next = last;

            PrintList(first);

            Console.Read();
        }

        public static void PrintList(Node node)
        { 
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
