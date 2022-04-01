using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.LinkedList
{
    public class SingleLinkedList
    {
        public Node head;
        public static int counter = 0;
        public int GetCounter()
        {
            return counter;
        }
        public void AppendLink(int data)
        {
            if (head == null)
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                Node newNode = new Node(data);
                temp.next = newNode;
            }
        }
        public void InsertBefore(int oldValue, int newValue)
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty!");
            }
            else if (Includes(oldValue))
            {
                Node temp = head;
                Node node = new Node(newValue);
                if (temp.next == null)
                {
                    node.next = temp;
                    head = node;
                }
                else if (temp.data == oldValue)
                {
                    node.next = temp;
                    head = node;
                }
                else
                {
                    while (temp.next.data != oldValue)
                    {
                        temp = temp.next;
                    }

                    node.next = temp.next;
                    temp.next = node;
                }
            }
            else
            {
                Console.WriteLine("Can't Insert!");
            }
        }
        public void InsertAfter(int oldValue, int newValue)
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty!");
            }
            else if (Includes(oldValue))
            {
                Node temp = head;
                while (temp.data != oldValue)
                {
                    temp = temp.next;
                }
                Node newNode = new Node(newValue);
                if (temp.next != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    temp.next = newNode;
                }
            }
            else
            {
                Console.WriteLine("Can't Insert!");
            }
        }
        public void DeleteNode(int data)
        {
            if (Includes(data))
            {
                counter--;
                Node temp = head;
                Node prev = null;
                if (temp != null && temp.data == data)
                {
                    head = temp.next;
                    return;
                }
                while (temp != null && temp.data != data)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;
            }
            else
            {
                Console.WriteLine("You can't delete a value that doesn't exist!");
            }
        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public bool Includes(int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public string LinkedListToString()
        {
            string outPut = "";
            Node temp = head;
            while (temp != null)
            {
                outPut += $"[{temp.data}] -> ";
                temp = temp.next;
            }
            outPut += "NULL";
            return outPut;
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            SingleLinkedList.counter++;
            this.data = data;
            next = null;
        }
    }
}
