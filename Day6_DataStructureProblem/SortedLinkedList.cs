using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_DataStructureProblem
{
    public class SortedLinkedList<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;
        private int count;

        public SortedLinkedList()
        {
            head = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void InsertDescending(T data)
        {
            Node newNode = new Node(data);

            if (head == null || data.CompareTo(head.Data) > 0)
            {
                newNode.Next = head;
                head = newNode;
                count++;
                return;
            }

            Node current = head;
            while (current.Next != null && data.CompareTo(current.Next.Data) <= 0)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
