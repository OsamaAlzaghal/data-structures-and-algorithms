using DataStructure.DSA.ArrayBinarySearch;
using DataStructure.DSA.ArrayReverse;
using DataStructure.DSA.ArrayShift;
using DataStructure.DSA.LinkedList;
using DataStructure.DSA.Stack_Queue;
using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            // ArrayReverse.reverseArray(array);

            /*
            int[] arrOne = { 2, 4, 6, -8 };
            int[] arrTwo = { 42, 8, 15, 23, 42 };
            int[] newArrOne = ArrayShift.insertShiftArray(arrOne, 5);
            int[] newArrTwo = ArrayShift.insertShiftArray(arrTwo, 16);
            Console.WriteLine("Array before and after shifting: ");
            Console.WriteLine(string.Join(", ", arrOne));
            Console.WriteLine(string.Join(", ", newArrOne));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Arrays before and after shifting:");
            Console.WriteLine(string.Join(", ", arrTwo));
            Console.WriteLine(string.Join(", ", newArrTwo));
            */

            /*
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(ArrayBinarySearch.BinarySearch(arr, 4));
            Console.WriteLine(ArrayBinarySearch.BinarySearch(arr, 7));
            Console.WriteLine(ArrayBinarySearch.BinarySearch(arr, 25));
            */

            //SingleLinkedList testLink = new SingleLinkedList();
            /*testLink.AppendLink(777);
            testLink.Insert(10);
            testLink.InsertAfter(10, 15);
            testLink.InsertBefore(777, 123);
            testLink.InsertAfter(123, 999);
            testLink.AppendLink(100);
            testLink.InsertAfter(123, 76);
            testLink.AppendLink(101010);
            testLink.DeleteNode(999);
            Console.WriteLine(testLink.LinkedListToString());
            Console.WriteLine($"Counter: {testLink.GetCounter()}");
            Console.WriteLine($"Includes 76? {testLink.Includes(76)}.");
            // [10] -> [15] -> [123] -> [76] -> [777] -> [100] -> [101010] -> NULL
            */

            //testLink.AppendLink(1);
            //Console.WriteLine(testLink.KthFromEnd(0));
            //Console.WriteLine(testLink.KthFromEnd(4));
            //Console.WriteLine(testLink.KthFromEnd(2));
            // Both should throw exception with a message and return -1.
            //Console.WriteLine(testLink.KthFromEnd(23));
            //Console.WriteLine(testLink.KthFromEnd(-5));

            SingleLinkedList list1 = new SingleLinkedList();  // Create first list and append some values.
            list1.AppendLink(1);
            list1.AppendLink(2);
            list1.AppendLink(3);
            SingleLinkedList list2 = new SingleLinkedList();  // Create second list and append some values.
            list2.AppendLink(4);
            list2.AppendLink(5);
            list2.AppendLink(6);
            Console.WriteLine(list2.LinkedListToString());    // Print the first list then the second one.
            Console.WriteLine(list1.LinkedListToString());
            SingleLinkedList.ZipLists(list1, list2);          // This will return a the zipped list. 
            Console.WriteLine(list1.LinkedListToString());    // Since the method return list1 after zipping it
                                                              // with list2, you can print it and see the difference.

            //Stack newStack = new Stack();
            //newStack.Peek();
            //newStack.Push(10);
            //newStack.Push(15);
            //Console.WriteLine(newStack.IsEmpty()); // false
            //newStack.Pop(); // 15
            //newStack.Peek(); // 10

            //Console.WriteLine("\n************************");
            //Queue newQueue = new Queue();
            //newQueue.Peek();
            //newQueue.Enqueue(10);
            //newQueue.Enqueue(15);
            //Console.WriteLine(newQueue.IsEmpty()); // false
            //newQueue.Dequeue(); // 10
            //newQueue.Peek(); // 15
        }
    }
}
