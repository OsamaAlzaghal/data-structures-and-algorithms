using DataStructure.DSA.ArrayBinarySearch;
using DataStructure.DSA.ArrayReverse;
using DataStructure.DSA.ArrayShift;
using DataStructure.DSA.LinkedList;
using DataStructure.DSA.LinkedListInsertions;
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

            LinkedListInsertions testLink = new LinkedListInsertions();
            // Created new Linked List called testLink. 
            // The head will point to null since it's empty.
            testLink.AppendLink(777);
            // Add to the last.
            // [777] -> NULL 
            testLink.Insert(10);
            // Add to the front.
            // [10] -> [777] -> NULL
            testLink.InsertAfter(10, 15);
            // Add after 10.
            // [10] -> [15] -> [777] -> NULL
            testLink.InsertBefore(777, 123);
            // Add before 777.
            // [10] -> [15] -> [123] -> [777] -> NULL
            testLink.InsertAfter(123, 999);
            // Add after 123.
            // [10] -> [15] -> [123] -> [999] -> [777] -> NULL
            testLink.AppendLink(100);
            // Add to the last.
            // [10] -> [15] -> [123] -> [999] -> [777] -> [100] -> NULL
            testLink.InsertAfter(123, 76);
            // Add after 123.
            // [10] -> [15] -> [123] -> [76] -> [999] -> [777] -> [100] -> NULL
            testLink.AppendLink(101010);
            // Add to the last.
            // [10] -> [15] -> [123] -> [76] -> [999] -> [777] -> [100] -> [101010] -> NULL
            testLink.DeleteNode(999);
            // This was optional, but I did it.
            // [10] -> [15] -> [123] -> [76] -> [777] -> [100] -> [101010] -> NULL
            Console.WriteLine(testLink.LinkedListToString());
            Console.WriteLine($"Counter: {testLink.GetCounter()}");
            // We have 7 nodes since we deleted one.
            Console.WriteLine($"Includes 76? {testLink.Includes(76)}.");
            // To check if there is a node containing 76.
            

        }
    }
}
