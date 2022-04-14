using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.QueueUsingStacks;
using Xunit;

namespace TestDataStructure
{
    public class TestPseudoQueue
    {
        [Fact]
        public void EnqueueTest()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.Enqueue(1);
            pseudoQueue.Enqueue(2);
            Assert.Equal("[2] -> [1] -> NULL", pseudoQueue.PrintQueue());
            pseudoQueue.Enqueue(3);
            Assert.Equal("[3] -> [2] -> [1] -> NULL", pseudoQueue.PrintQueue());
        }

        [Fact]
        public void DequeueTest()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.Enqueue(1);
            pseudoQueue.Enqueue(2);
            pseudoQueue.Enqueue(3);
            pseudoQueue.Dequeue();
            Assert.Equal("[3] -> [2] -> NULL", pseudoQueue.PrintQueue());
        }

        [Fact]
        public void DequeueEmptyQueue()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            Assert.Null(pseudoQueue.Dequeue());
        }
    }
}
