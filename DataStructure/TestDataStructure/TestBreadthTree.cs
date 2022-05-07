using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.TreeBreadthFirst;
using Xunit;


namespace TestDataStructure
{
    public class TestBreadthTree
    {
        [Fact]
        public void EmptyTreeTest()
        {
            BreadthFirst tree = new BreadthFirst();
            Assert.Null(tree.BreadthFirstTree(tree.Root));
        }

        [Fact]
        public void ValidTreeTest()
        {
            BreadthFirst tree = new BreadthFirst();
            tree.Add(12); tree.Add(13); tree.Add(7); tree.Add(5); tree.Add(1); tree.Add(20);
            int[] arr = { 12, 7, 13, 5, 20, 1 };
            Assert.Equal(tree.BreadthFirstTree(tree.Root), arr);
        }
    }
}
