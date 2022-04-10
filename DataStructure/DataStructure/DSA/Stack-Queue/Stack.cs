using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.Node;

namespace DataStructure.DSA.Stack_Queue
{
    public class Stack
    {
        public Node.Node top;
        public Stack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node.Node newNode = new Node.Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("Pushed {0} to stack", value);
        }

        public int? Pop()
        {
            try
            {
                if (top == null)
                {
                    throw new Exception("Stack is empty, Deletion not possible.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            Node.Node temp = top;
            Console.WriteLine("Item popped is: {0}", top.data);
            top = top.next;

            return temp.data;
        }

        public int? Peek()
        {
            try
            {
                if (top == null)
                {
                    throw new Exception("Stack is empty.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            Console.WriteLine("Top of Stack: {0}", top.data);

            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
