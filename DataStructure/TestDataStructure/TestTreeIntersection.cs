using DataStructure.DSA.Tree;
using DataStructure.DSA.Tree_Intersection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestDataStructure
{
    public class TestTreeIntersection
    {
        [Fact]
        public void TestIntersection()
        {
            TreeIntersection intersection = new TreeIntersection();

            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.Add(150); tree1.Add(100); tree1.Add(250); tree1.Add(75); tree1.Add(160);
            tree1.Add(125); tree1.Add(175); tree1.Add(200); tree1.Add(300); tree1.Add(350); tree1.Add(500);

            BinarySearchTree tree2 = new BinarySearchTree();
            tree2.Add(42); tree2.Add(100); tree2.Add(600); tree2.Add(15); tree2.Add(160); tree2.Add(125);
            tree2.Add(175); tree2.Add(500); tree2.Add(4); tree2.Add(200); tree2.Add(350);

            List<int> list = new List<int> { 100, 200, 500, 160, 175, 125, 350 };
            // This is our return list: [100, 200, 500, 160, 175, 125, 350].

            Xunit.Assert.Equal(list, intersection.Tree_Intersection(tree1, tree2));
        }

        [Fact]
        [ExpectedException(typeof(ArgumentException), "One odfgf the trees is empty!")]
        public void TestEmptyTrees()
        {
            TreeIntersection intersection = new TreeIntersection();
            BinarySearchTree tree1 = new BinarySearchTree();
            BinarySearchTree tree2 = new BinarySearchTree();
            intersection.Tree_Intersection(tree1, tree2);
        }

        [Fact]
        
        public void TestNoIntersection()
        {
            TreeIntersection intersection = new TreeIntersection();

            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.Add(1); tree1.Add(2); tree1.Add(3); tree1.Add(4); tree1.Add(5);
            
            BinarySearchTree tree2 = new BinarySearchTree();
            tree2.Add(6); tree2.Add(7); tree2.Add(8); tree2.Add(9); tree2.Add(10); tree2.Add(11);
            Xunit.Assert.Null(intersection.Tree_Intersection(tree1, tree2));
        }
    }
}
