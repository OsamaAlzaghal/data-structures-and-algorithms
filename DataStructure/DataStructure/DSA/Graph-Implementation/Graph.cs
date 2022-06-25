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

        public Node AddNode(string value)
        {
            Node node = new Node(value);
            vertexSet.Add(node);
            return node;
        }

        public void AddEdge(string Value1, string Value2, int weight)
        {
            try
            {
                Node node = this.GetNode(Value1);
                
                     node.AddEdge(Value2, weight);
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

        private Node GetNode(string value)
        {
            try { return vertexSet.Where(x => x.Value == value).Select(x => x).FirstOrDefault(); }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Dictionary<string, int> GetNeighbors(string value)
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
        public readonly string Value;
        // <Vertex, Weight>
        public readonly Dictionary<string, int> Neighbors;

        public Node(string value)
        {
            this.Value = value;
            this.Neighbors = new Dictionary<string, int>();
        }

        public void AddEdge(string value, int weight)
        {
            if (this.Value == value)
            {
                throw new ArgumentException("The vertex cannot be adjacent to itself!");
            }

            this.Neighbors.Add(value, weight);
        }

        public Dictionary<string, int> GetAdjacentVertices()
        {
            return this.Neighbors;
        }
    }
}