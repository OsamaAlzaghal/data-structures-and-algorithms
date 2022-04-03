using System;
using Xunit;
using DataStructure.DSA.LinkedList;

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

    }
}
