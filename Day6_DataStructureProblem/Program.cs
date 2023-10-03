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
                Console.WriteLine("1.Generic class custom Linkedlist datastructure");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

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
