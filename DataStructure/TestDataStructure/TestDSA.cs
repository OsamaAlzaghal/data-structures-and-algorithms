using System;
using Xunit;
using DataStructure.DSA.LinkedList;
using DataStructure.DSA.Stack_Queue;

namespace TestDataStructure
{
    public class TestDSA
    {
        [Fact]
        public void CreateEmptyLinkedListTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            Assert.Null(testLink.head);
        }
        [Fact]
        public void InsertTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.Insert(10);
            Node temp = testLink.head;
            Assert.NotNull(testLink.head);
            Assert.Equal(10, temp.data);
        }
        [Fact]
        public void HeadTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.Insert(10);
            testLink.Insert(20);
            Node temp = testLink.head;
            Assert.Equal(20, temp.data);
        }
        [Fact]
        public void InsertMultipleNodesTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.Insert(9);
            testLink.Insert(34);
            testLink.Insert(56);
            testLink.Insert(95);
            Node temp = testLink.head;
            Assert.Equal(95, temp.data);
        }
        [Fact]
        public void IncludesFoundTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.Insert(9);
            testLink.Insert(34);
            Assert.True(testLink.Includes(34));
        }
        [Fact]
        public void IncludesNotFoundTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.Insert(9);
            testLink.Insert(34);
            Assert.False(testLink.Includes(100));
        }
        [Fact]
        public void ValesTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.Insert(10);
            testLink.Insert(15);
            testLink.Insert(18);
            testLink.Insert(20);
            Assert.Equal("[20] -> [18] -> [15] -> [10] -> NULL", testLink.LinkedListToString());
        }

        [Fact]
        public void AppendLinkTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.AppendLink(777);
            testLink.AppendLink(100);
            testLink.AppendLink(15);
            testLink.AppendLink(20);
            Assert.Equal("[777] -> [100] -> [15] -> [20] -> NULL", testLink.LinkedListToString());
        }

        [Fact]
        public void InsertBeforeMiddleTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            // If the list is empty, I can't insert before a value so I print
            // that it's empty.
            testLink.Insert(1);
            testLink.InsertAfter(1, 2);
            testLink.InsertAfter(2, 3);
            // Insert befor middle which is 2.
            testLink.InsertBefore(2, 10);
            Assert.Equal("[1] -> [10] -> [2] -> [3] -> NULL", testLink.LinkedListToString());
        }

        [Fact]
        public void InsertBeforeFirstTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            // If the list is empty, I can't insert before a value so I print
            // that it's empty.
            testLink.Insert(777);
            testLink.InsertBefore(777, 100);
            Assert.Equal("[100] -> [777] -> NULL", testLink.LinkedListToString());
        }

        [Fact]
        public void InsertAfterMiddle()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.AppendLink(1);
            testLink.AppendLink(2);
            testLink.AppendLink(3);
            testLink.InsertAfter(2, 99);
            Assert.Equal("[1] -> [2] -> [99] -> [3] -> NULL", testLink.LinkedListToString());
        }

        [Fact]
        public void InsertAfterLast()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.AppendLink(1);
            testLink.AppendLink(2);
            testLink.AppendLink(3);
            testLink.InsertAfter(3, 99);
            Assert.Equal("[1] -> [2] -> [3] -> [99] -> NULL", testLink.LinkedListToString());
        }

        [Fact]
        public void GreaterThanLengthTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.AppendLink(1);
            testLink.AppendLink(2);
            testLink.AppendLink(3);
            // It will throw an exception and return -1.
            Assert.Null(testLink.KthFromEnd(6));
        }

        [Fact]
        public void LengthEqualsKTest()
        {
            SingleLinkedList osama = new SingleLinkedList();
            osama.AppendLink(1);
            osama.AppendLink(2);
            // K=1; because the counter of length starts from 0 and not 1.
            // so it is equal to the counter/length.
            Assert.Equal(1, osama.KthFromEnd(1));
        }

        [Fact]
        public void NegativeKValue()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.AppendLink(1);
            testLink.AppendLink(2);
            testLink.AppendLink(3);
            // It will throw an exception and return -1.
            Assert.Null(testLink.KthFromEnd(-3));
        }

        [Fact]
        public void SizeOfOneTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.AppendLink(1);
            Assert.Equal(1, testLink.KthFromEnd(0));
        }

        [Fact]
        public void MiddleKTest()
        {
            SingleLinkedList testLink = new SingleLinkedList();
            testLink.AppendLink(1);
            testLink.AppendLink(2);
            testLink.AppendLink(3);
            testLink.AppendLink(4);
            testLink.AppendLink(5);
            Assert.Equal(3, testLink.KthFromEnd(2));
        }

        [Fact]
        public void NullListsTest()
        {
            SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();
            Assert.Null(SingleLinkedList.ZipLists(list1, list2).head);
        }

        [Fact]
        public void FirstListIsNullTest()
        {
            SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();
            list2.AppendLink(1);
            list2.AppendLink(2);
            list2.AppendLink(3);
            Assert.Equal("[1] -> [2] -> [3] -> NULL", SingleLinkedList.ZipLists(list1, list2).LinkedListToString());
        }

        [Fact]
        public void SecondListIsNullTest()
        {
            SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();
            list1.AppendLink(1);
            list1.AppendLink(2);
            list1.AppendLink(3);
            Assert.Equal("[1] -> [2] -> [3] -> NULL", SingleLinkedList.ZipLists(list1, list2).LinkedListToString());
        }

        [Fact]
        public void FirstListLonger()
        {
            SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();
            list1.AppendLink(1);
            list1.AppendLink(2);
            list1.AppendLink(3);
            list1.AppendLink(4);
            list2.AppendLink(5);
            list2.AppendLink(6);
            Assert.Equal("[1] -> [5] -> [2] -> [6] -> [3] -> [4] -> NULL", SingleLinkedList.ZipLists(list1, list2).LinkedListToString());
        }

        [Fact]
        public void SecondListLonger()
        {
            SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();
            list1.AppendLink(1);
            list1.AppendLink(2);
            list2.AppendLink(3);
            list2.AppendLink(4);
            list2.AppendLink(5);
            list2.AppendLink(6);
            Assert.Equal("[1] -> [3] -> [2] -> [4] -> [5] -> [6] -> NULL", SingleLinkedList.ZipLists(list1, list2).LinkedListToString());
        }

        [Fact]
        public void StackPushTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(76);
            stack.Push(15);
            Assert.Equal(15, stack.top.data);
        }

        [Fact]
        public void StackPopTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(15);
            Assert.Equal(15, stack.Pop());
        }

        [Fact]
        public void EmptyTheStackTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(15);
            stack.Pop();
            stack.Pop();
            Assert.Null(stack.top);
        }

        [Fact]
        public void StackPeekTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(15);
            Assert.Equal(15, stack.Peek());
        }

        [Fact]
        public void StackIsEmptyTest()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void PopPeekEmptyStack()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Pop());
            Assert.Null(stack.Peek());
        }

        [Fact]
        public void InsertIntoQueueTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(50);
            Assert.Equal(10, queue.front.data);
            Assert.Equal(50, queue.rear.data);
        }

        [Fact]
        public void DeleteFromQueueTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(15);
            Assert.Equal(10, queue.Dequeue());
        }

        [Fact]
        public void PeekQueueTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(34);
            queue.Enqueue(52);
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void EmptyTheQueueTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Dequeue();
            queue.Dequeue();
            Assert.Null(queue.front);
            Assert.Null(queue.rear);
        }

        [Fact]
        public void QueueIsEmptyTest()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void DequeuePeekEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Dequeue());
            Assert.Null(queue.Peek());
        }
    }
}