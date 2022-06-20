using DataStructure.DSA.Tree;
//using Node = DataStructure.DSA.Tree.Node;
using DataStructure.DSA.Tree_Intersection;
using System.Collections.Generic;
using DataStructure.DSA.Graph_Implementation;

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
            //Quick_Sort.PrintArray(array);
            //Quick_Sort.QuickSortMethod(array, 0, array.Length - 1);
            //Quick_Sort.PrintArray(array);

            //TreeIntersection intersection = new TreeIntersection();

            //BinarySearchTree tree1 = new BinarySearchTree();
            //tree1.Add(150); tree1.Add(100); tree1.Add(250); tree1.Add(75); tree1.Add(160);
            //tree1.Add(125); tree1.Add(175); tree1.Add(200); tree1.Add(300); tree1.Add(350); tree1.Add(500);

            //BinarySearchTree tree2 = new BinarySearchTree();
            //tree2.Add(42); tree2.Add(100); tree2.Add(600); tree2.Add(15); tree2.Add(160); tree2.Add(125);
            //tree2.Add(175); tree2.Add(500); tree2.Add(4); tree2.Add(200); tree2.Add(350);

            //TreeIntersection.PrintList(intersection.Tree_Intersection(tree1, tree2));

            Graph graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddEdge(1, 2, 10);
            var x = graph.GetNeighbors(1);
            // 2
            System.Console.WriteLine(x.ContainsKey(1));
        }
    }
}