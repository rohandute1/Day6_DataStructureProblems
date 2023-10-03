using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_DataStructureProblem
{
    public class CustomStack<T>
    {
        private T[] items;
        private int count;

        public CustomStack(int capacity)
        {
            items = new T[capacity];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Push(T item)
        {
            if (count < items.Length)
            {
                items[count] = item;
                count++;
            }
            else
            {
                Console.WriteLine("Stack is full. Cannot push.");
            }
        }

        public T Pop()
        {
            if (count > 0)
            {
                count--;
                return items[count];
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return default(T);
            }
        }

        public T Peek()
        {
            if (count > 0)
            {
                return items[count - 1];
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot peek.");
                return default(T);
            }
        }

        public void Clear()
        {
            count = 0;
        }
    }
}
