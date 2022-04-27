using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.Tree;
using Xunit;

namespace TestDataStructure
{
    public class TestMaxBinaryTree
    {
        [Fact]
        public void MaxElementTest()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(30);
            binarySearchTree.Add(23);
            binarySearchTree.Add(18);
            Assert.Equal(30, binarySearchTree.MaxTree());
        }

        [Fact]
        public void EmptyTreeTest()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            Assert.Null(binarySearchTree.MaxTree());
        }

        [Fact]
        public void AllValueAreTheSameTest()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(30);
            binarySearchTree.Add(30);
            binarySearchTree.Add(30);
            Assert.Equal(30, binarySearchTree.MaxTree());
        }
    }
}
