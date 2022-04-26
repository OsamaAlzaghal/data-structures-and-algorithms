using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructure.DSA.Tree;

namespace TestDataStructure
{

    public class TestTrees
    {
        [Fact]
        public void TestEmptyTree()
        {
            BinaryTree binaryTree = new BinaryTree();
            Assert.Null(binaryTree.Root);
        }

        [Fact]
        public void TestAdd()
        {
            BinaryTree binaryTree = new BinaryTree(new Node(10));
            Assert.Equal(10, binaryTree.Root.Value);
        }

        [Fact]
        public void TestBinarySearchTreeAdd()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(5);
            binarySearchTree.Add(16);
            Assert.Equal(5, binarySearchTree.Root.Left.Value);
            Assert.Equal(16, binarySearchTree.Root.Right.Value);
        }

        [Fact]
        public void TestPreOrder()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(3);
            binarySearchTree.Add(1);
            binarySearchTree.Add(10);
            List<int> list = new List<int>();
            list.Add(3); list.Add(1); list.Add(10);
            Assert.Equal(list, binarySearchTree.PreOrder(binarySearchTree.Root));
        }

        [Fact]
        public void TestInOrder()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(3);
            binarySearchTree.Add(1);
            binarySearchTree.Add(10);
            List<int> list = new List<int>();
            list.Add(1); list.Add(3); list.Add(10);
            Assert.Equal(list, binarySearchTree.InOrder(binarySearchTree.Root));
        }

        [Fact]
        public void TestPostOrder()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(3);
            binarySearchTree.Add(1);
            binarySearchTree.Add(10);
            List<int> list = new List<int>();
            list.Add(1); list.Add(10); list.Add(3);
            Assert.Equal(list, binarySearchTree.PostOrder(binarySearchTree.Root));
        }

        [Fact]
        public void TestContains()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(1);
            binarySearchTree.Add(10);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            Assert.True(binarySearchTree.Contains(binarySearchTree.Root, 1));
            Assert.False(binarySearchTree.Contains(binarySearchTree.Root, 99));
        }
    }
}
