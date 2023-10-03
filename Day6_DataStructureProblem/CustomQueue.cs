using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_DataStructureProblem
{
    public class CustomQueue<T>
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
        private Node tail;
        private int count;

        public CustomQueue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Enqueue(T item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T item = head.Data;
            head = head.Next;
            count--;

            if (count == 0)
            {
                tail = null;
            }

            return item;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return head.Data;
        }

        public bool Contains(T item)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }
}
