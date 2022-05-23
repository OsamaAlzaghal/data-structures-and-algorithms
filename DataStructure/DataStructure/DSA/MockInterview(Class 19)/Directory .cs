using DataStructure.DSA.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.MockInterview_Class_19_
{
    public class Directory
    {
        public Node Root { get; set; }
        public bool EqualLeaves(Node tree)
        {
            if (LeavesCount(Root) != LeavesCount(tree)){ return false; }
            return true;
        }

        public int LeavesCount(Node root)
        {
            if(root == null) { return 0; }
            if(root.Left == null && root.Right == null) { return 1; }
            else { return LeavesCount(root.Left) + LeavesCount(root.Right); }
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
}
