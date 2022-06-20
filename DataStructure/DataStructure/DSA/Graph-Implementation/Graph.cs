using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.DSA.Graph_Implementation
{
    public class Graph
    {
        private readonly HashSet<Node> vertexSet;
        private readonly bool Directed;

        public Graph(bool directed = false)
        {
            this.Directed = directed;
            this.vertexSet = new HashSet<Node>();
        }

        public Node AddNode(int value)
        {
            Node node = new Node(value);
            vertexSet.Add(node);
            return node;
        }

        public void AddEdge(int Value1, int Value2, int weight)
        {
            try
            {
                this.GetNode(Value1).AddEdge(Value2, weight);
                if (!this.Directed) { this.GetNode(Value2).AddEdge(Value1, weight); }
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public HashSet<Node> GetNodes()
        {
            return this.vertexSet;
        }

        private Node GetNode(int value)
        {
            try { return vertexSet.Where(x => x.Value == value).Select(x => x).FirstOrDefault(); }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<int, int> GetNeighbors(int value)
        {
            return this.GetNode(value).GetAdjacentVertices();
        }

        public int Size()
        {
            return this.vertexSet.Count;
        }
    }

    public class Node
    {
        public readonly int Value;
        // <Vertex, Weight>
        public readonly Dictionary<int, int> Neighbors;

        public Node(int value)
        {
            this.Value = value;
            this.Neighbors = new Dictionary<int, int>();
        }

        public void AddEdge(int value, int weight)
        {
            if (this.Value == value)
            {
                throw new ArgumentException("The vertex cannot be adjacent to itself!");
            }

            this.Neighbors.Add(value, weight);
        }

        public Dictionary<int, int> GetAdjacentVertices()
        {
            return this.Neighbors;
        }
    }
}