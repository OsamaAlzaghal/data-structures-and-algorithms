using DataStructure.DSA.Tree;
using System.Collections.Generic;
namespace DataStructure.DSA.TreeBreadthFirst
{
    public class BreadthFirst : BinarySearchTree
    {
        public List<int> BreadthFirstTree(DataStructure.DSA.Tree.Node root)
        {
            if(root == null)
            {
                return null;
            }

            List<int> result = new List<int>();
            Queue<DataStructure.DSA.Tree.Node> breadthQueue= new Queue<DataStructure.DSA.Tree.Node>();

            breadthQueue.Enqueue(root);
            while (breadthQueue.Count > 0)
            {
                DataStructure.DSA.Tree.Node front = breadthQueue.Dequeue();
                result.Add(front.Value);

                if (front.Left != null)
                    breadthQueue.Enqueue(front.Left);

                if (front.Right != null)
                    breadthQueue.Enqueue(front.Right);
            }
            return result;
        }
    }
}
