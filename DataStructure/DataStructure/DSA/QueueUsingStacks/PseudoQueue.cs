using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.Stack_Queue;
using DataStructure.DSA.Node;
using static DataStructure.DSA.LinkedList.SingleLinkedList;

namespace DataStructure.DSA.QueueUsingStacks
{
    public class PseudoQueue
    {
        Stack stack1;
        Stack stack2;
        public PseudoQueue()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }

        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int? Dequeue()
        {
            if (stack1.IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return null;
            }
            else
            {
                while (!stack1.IsEmpty())
                {
                    stack2.Push(stack1.Pop());
                }
                int? value = stack2.Pop();
                while (!stack2.IsEmpty())
                {
                    stack1.Push(stack2.Pop());
                }
                return value;
            }
        }

        public string PrintQueue()
        {
            string outPut = "";
            Node.Node temp = stack1.top;
            while (temp != null)
            {
                outPut += $"[{temp.data}] -> ";
                temp = temp.next;
            }
            outPut += "NULL";
            return outPut;
        }
    }
}
