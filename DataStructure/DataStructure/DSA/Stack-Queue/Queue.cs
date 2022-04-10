using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.Node;

namespace DataStructure.DSA.Stack_Queue
{
    public class Queue
    {
        public Node.Node front;
        public Node.Node rear;

        public Queue()
        {
            front = rear = null;
        }

        public void Enqueue(int item)
        {
            Node.Node newNode = new Node.Node(item);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            Console.WriteLine("Inserted {0} into Queue", item);
        }

        public int? Dequeue()
        {
            try
            {
                if (front == null)
                {
                    throw new Exception("The Queue is empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            Node.Node temp = front;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            Console.WriteLine("Item dequeued is: {0}", temp.data);
            return temp.data;
        }

        public int? Peek()
        {
            try
            {
                if (front == null)
                {
                    throw new Exception("Queue is empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return front.data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
