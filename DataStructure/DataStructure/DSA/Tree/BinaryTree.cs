using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<int> List { get; set; }
        public BinaryTree(Node root = null)
        {
            Root = root;
            List = new List<int>();
        }

        public List<int> PreOrder(Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            if(Root == root)
            {
                List.Clear();
            }
            List.Add(root.Value);
            if(root.Left != null)
            {
                PreOrder(root.Left);
            }
            if(root.Right != null)
            {
                PreOrder(root.Right);
            }
            return List;
        }

        public List<int> InOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            if (Root == root)
            {
                List.Clear();
            }
            if (root.Left != null)
            {
                InOrder(root.Left);
            }
            List.Add(root.Value);
            if (root.Right != null)
            {
                InOrder(root.Right);
            }
            return List;
        }

        public List<int> PostOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            if (Root == root)
            {
                List.Clear();
            }
            if (root.Left != null)
            {
                PostOrder(root.Left);
            }
            if(root.Right != null)
            {
                PostOrder(root.Right);
            }
            List.Add(root.Value);
            return List;
        }

        public string ToString(List<int> list)
        {
            if (list == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            string toStringList = "";
            foreach (var item in list)
            {
                toStringList += $"{item}, ";
            }
            return toStringList = toStringList.Remove(toStringList.Length - 2);
        }

        public int? MaxTree()
        {
            if(InOrder(this.Root) == null)
            {
                Console.WriteLine("Tree is empty!");
                return null;
            }
            return InOrder(this.Root).Max();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(Node root = null) : base(root)
        { }

        public void Add(int value)
        {
            Node position, temp;
            position = temp = this.Root;
            Node newNode = new Node(value);

            while (temp != null)
            {
                position = temp;
                if (value < position.Value)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < position.Value)
                {
                    position.Left = newNode;
                }
                else
                {
                    position.Right = newNode;
                }   
            } 
        }

        public bool Contains(Node root, int item)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Value == item)
            {
                return true;
            }
            if (item < root.Value)
            {
                return Contains(root.Left, item);
            }
            else
            {
                return Contains(root.Right, item);
            }
        }
    }
}