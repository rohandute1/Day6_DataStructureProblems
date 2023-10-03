using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_DataStructureProblem
{
    public class LinkedListOperations
    {
        private LinkedList<int> linkedList;

        public LinkedListOperations()
        {
            linkedList = new LinkedList<int>();
        }

        public void Create(int value)
        {
            linkedList.AddLast(value);
        }

        public int RetrieveFirst()
        {
            if (linkedList.Count == 0)
            {
                Console.WriteLine("LinkedList is empty.");
                return default;
            }
            return linkedList.First.Value;
        }

        public int RetrieveLast()
        {
            if (linkedList.Count == 0)
            {
                Console.WriteLine("LinkedList is empty.");
                return default;
            }
            return linkedList.Last.Value;
        }

        public void Update(int oldValue, int newValue)
        {
            LinkedListNode<int> nodeToUpdate = linkedList.Find(oldValue);
            if (nodeToUpdate != null)
            {
                nodeToUpdate.Value = newValue;
            }
            else
            {
                Console.WriteLine("Value not found in the LinkedList.");
            }
        }

        public void Delete(int value)
        {
            LinkedListNode<int> nodeToDelete = linkedList.Find(value);
            if (nodeToDelete != null)
            {
                linkedList.Remove(nodeToDelete);
            }
            else
            {
                Console.WriteLine("Value not found in the LinkedList.");
            }
        }

        public void Print()
        {
            foreach (int item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
