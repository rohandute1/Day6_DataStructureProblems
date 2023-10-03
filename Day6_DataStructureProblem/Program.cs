using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_DataStructureProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Problems.");
            bool continueExecution = true;
            while (continueExecution)
            {
                Console.WriteLine("Please choose program to perform:");
                Console.WriteLine("1.Generic class custom Linkedlist datastructure\n2.Generic class custom Stack datastructure");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:

                        CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();

                        customLinkedList.AddFirst(1);
                        customLinkedList.AddLast(2);
                        customLinkedList.AddLast(3);

                        Console.WriteLine("Custom Linked List:");
                        customLinkedList.Print(); 

                        customLinkedList.Remove(2);

                        Console.WriteLine("Custom Linked List after removing 2:");
                        customLinkedList.Print(); 

                        Console.WriteLine("Does the custom linked list contain 2? " + customLinkedList.Contains(2)); 
                        break;

                    case 2:
                        CustomStack<int> stack = new CustomStack<int>(5);

                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);

                        Console.WriteLine("Stack Count: " + stack.Count);
                        Console.WriteLine("Top Element: " + stack.Peek());

                        int poppedItem = stack.Pop();
                        Console.WriteLine("Popped Element: " + poppedItem);

                        Console.WriteLine("Stack Count after Pop: " + stack.Count);

                        stack.Clear();
                        Console.WriteLine("Stack Count after Clear: " + stack.Count); 

                        stack.Push(4);
                        stack.Push(5);
                        stack.Push(6); 

                        stack.Clear();
                        stack.Pop(); 

                        stack.Peek();
                        break;
                }
                Console.WriteLine("Do you want to continue.(yes/no)");
                string userInput = Console.ReadLine();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }
            Console.ReadLine();
        }
    }
}
