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
    }
}
