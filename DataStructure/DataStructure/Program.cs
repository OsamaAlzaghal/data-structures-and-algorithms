using DataStructure.DSA.ArrayBinarySearch;
using DataStructure.DSA.ArrayReverse;
using DataStructure.DSA.ArrayShift;
using DataStructure.DSA.LinkedList;
using DataStructure.DSA.QueueUsingStacks;
using DataStructure.DSA.Stack_Queue;
using DataStructure.DSA.AnimalsShelterQueue;
using DataStructure.DSA.Tree;
using DataStructure.DSA.Stack_Queue_Brackets;
//using Node = DataStructure.DSA.Tree.Node;
using Node = DataStructure.DSA.MockInterview_Class_19_.Node;
using System;
using DataStructure.DSA.TreeBreadthFirst;
using DataStructure.DSA.FizzBuzz;
using System.Collections.Generic;
using DataStructure.DSA.MockInterview_Class_19_;
using DataStructure.DSA.InsertionSort;
using DataStructure.DSA.Sorting.Merge;

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

            //SingleLinkedList list1 = new SingleLinkedList();  // Create first list and append some values.
            //list1.AppendLink(1);
            //list1.AppendLink(2);
            //list1.AppendLink(3);
            //SingleLinkedList list2 = new SingleLinkedList();  // Create second list and append some values.
            //list2.AppendLink(4);
            //list2.AppendLink(5);
            //list2.AppendLink(6);
            //Console.WriteLine(list2.LinkedListToString());    // Print the first list then the second one.
            //Console.WriteLine(list1.LinkedListToString());
            //SingleLinkedList.ZipLists(list1, list2);          // This will return a the zipped list. 
            //Console.WriteLine(list1.LinkedListToString());    // Since the method return list1 after zipping it
            //                                                  // with list2, you can print it and see the difference.

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

            //PseudoQueue pseudoQueue = new PseudoQueue();
            //Console.WriteLine(pseudoQueue.PrintQueue());
            //pseudoQueue.Enqueue(10);
            //pseudoQueue.Enqueue(15);
            //pseudoQueue.Enqueue(20);
            //Console.WriteLine(pseudoQueue.PrintQueue());
            //pseudoQueue.Enqueue(5);
            //Console.WriteLine(pseudoQueue.PrintQueue());
            //Console.WriteLine(pseudoQueue.Dequeue());
            //Console.WriteLine(pseudoQueue.PrintQueue());

            //AnimalShelter animalShelter = new AnimalShelter(1, "Irbid Shelter");
            //Cat cat1 = new Cat("Lucy", 2);
            //Cat cat2 = new Cat("Sara", 4);
            //Dog dog1 = new Dog("Rex", 5);
            //Cat cat3 = new Cat("Meme", 1);
            //Dog dog2 = new Dog("Dennis", 7);
            //animalShelter.Enqueue(cat1);
            //animalShelter.Enqueue(cat2);
            //animalShelter.Enqueue(dog1);
            //animalShelter.Enqueue(cat3);
            //animalShelter.Enqueue(dog2);
            //Animal animal1 = animalShelter.Dequeue("cat");
            //Animal animal2 = animalShelter.Dequeue("dog");
            //Animal animal3 = animalShelter.Dequeue("cat");
            //Console.WriteLine(animal1.Name);
            //Console.WriteLine(animal2.Name);
            //Console.WriteLine(animal3.Name);

            //Console.WriteLine(StackQueueBrackets.ValidateBrackets("{(})"));

            //BinaryTree binaryTree = new BinaryTree(new Node(10));
            //binaryTree.Root.Left = new Node(8);
            //binaryTree.Root.Right = new Node(15);
            //binaryTree.Root.Left.Left = new Node(5);
            //binaryTree.Root.Right.Right = new Node(20);
            //Console.WriteLine(binaryTree.ToString(binaryTree.PreOrder(binaryTree.Root)));
            //Console.WriteLine(binaryTree.ToString(binaryTree.PostOrder(binaryTree.Root)));
            //Console.WriteLine(binaryTree.ToString(binaryTree.InOrder(binaryTree.Root)));
            //BinarySearchTree binarySearchTree = new BinarySearchTree(new Node(10));
            //binarySearchTree.Add(8);
            //binarySearchTree.Add(15);
            //binarySearchTree.Add(5);
            //binarySearchTree.Add(20);
            //Console.WriteLine(binarySearchTree.Contains(binaryTree.Root, 7));
            //Console.WriteLine(binarySearchTree.ToString(binarySearchTree.InOrder(binarySearchTree.Root)));
            //Console.WriteLine(binaryTree.MaxTree());

            //BreadthFirst tree = new BreadthFirst();
            //tree.Add(12); tree.Add(13); tree.Add(7); tree.Add(5); tree.Add(1); tree.Add(20); 
            //Console.WriteLine(tree.ToString(tree.BreadthFirstTree(tree.Root)));

            //Console.WriteLine("----------------------------------------------");

            //FizzBuzzTree root = new FizzBuzzTree("1");
            //root.Children.Add(new FizzBuzzTree("3"));
            //root.Children.Add(new FizzBuzzTree("5"));
            //root.Children.Add(new FizzBuzzTree("7"));
            //root.Children[0].Children.Add(new FizzBuzzTree("15"));
            //root.Children[0].Children.Add(new FizzBuzzTree("67"));
            //root.Children[0].Children.Add(new FizzBuzzTree("10"));
            //root.Children[1].Children.Add(new FizzBuzzTree("6"));
            //root.Children[2].Children.Add(new FizzBuzzTree("12"));
            //root.Children[2].Children.Add(new FizzBuzzTree("99"));
            //root.Children[2].Children.Add(new FizzBuzzTree("65"));

            //List<string> list = root.Traverse(root);
            //foreach (string s in list)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine("----------------------------------------------");

            //List<string> list2 = root.FizzBuzz(root);
            //foreach (string s in list2)
            //{
            //    Console.WriteLine(s);
            //}

            //Directory Tree1 = new Directory();
            //Tree1.Root = new Node(1);
            //Tree1.Root.Left = new Node(2);
            //Tree1.Root.Right = new Node(3);
            //Tree1.Root.Left.Left = new Node(4);
            //Tree1.Root.Left.Right = new Node(5);
            //Console.WriteLine("# of leaves for tree 1 : " + Tree1.LeavesCount(Tree1.Root) + ".");
            //Directory Tree2 = new Directory();
            //Tree2.Root = new Node(1);
            //Tree2.Root.Left = new Node(2);
            //Tree2.Root.Right = new Node(3);
            //Tree2.Root.Left.Left = new Node(4);
            //Tree2.Root.Left.Right = new Node(5);
            //Tree2.Root.Right.Left = new Node(6);
            //Tree2.Root.Right.Right = new Node(7);
            //Console.WriteLine("# of leaves for tree 2 : " + Tree2.LeavesCount(Tree2.Root) + ".");
            //Console.WriteLine("Do they have equal # of leaves? "+ Tree1.EqualLeaves(Tree2.Root)+ ".");

            //int[] array = { 8, 4, 23, 42, 16, 15 };
            //InsertionSort.PrintArray(array);
            //InsertionSort.InsertionSortMethod(array);
            //InsertionSort.PrintArray(array);

            int[] array = { 8, 4, 23, 42, 16, 15 };
            MergeSort.PrintArray(array);
            MergeSort.MergesortMethod(array);
            MergeSort.PrintArray(array);
        }
    }
}
