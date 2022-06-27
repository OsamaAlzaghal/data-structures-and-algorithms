using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructure.DSA.Graph_Implementation;


namespace TestDataStructure.TestGraph
{
    public class TestImplementation
    {
        [Fact]
        public void AddNodeTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama");
            Node node = graph.GetNode("Osama");
            Assert.NotNull(node);
        }

        [Fact]
        public void AddEdgeTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama");
            graph.AddNode("Rawan");
            graph.AddEdge("Osama", "Rawan", 100);

            var OsamaNeighbors = graph.GetNeighbors("Osama");
            var RawanNeighbors = graph.GetNeighbors("Rawan");

            Assert.True(OsamaNeighbors.ContainsKey("Rawan"));
            Assert.True(RawanNeighbors.ContainsKey("Osama"));
        }

        [Fact]
        public void GetNodesTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama");
            graph.AddNode("Rawan");
            HashSet<Node> test = new HashSet<Node>();
            test.Add(graph.GetNode("Osama"));
            test.Add(graph.GetNode("Rawan"));

            HashSet<Node> nodes = graph.GetNodes();
            Assert.Equal(test, nodes);
        }

        [Fact]
        public void GetVertexNeighborsTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama");
            graph.AddNode("Rawan");
            graph.AddNode("Ali");
            graph.AddNode("Fadi");
            graph.AddEdge("Osama", "Rawan", 100);
            graph.AddEdge("Osama", "Ali", 100);
            graph.AddEdge("Osama", "Fadi", 100);
            var neighbors = graph.GetNeighbors("Osama");

            Assert.True(neighbors.ContainsKey("Rawan")); Assert.True(neighbors.ContainsKey("Ali")); Assert.True(neighbors.ContainsKey("Fadi"));
        }

        [Fact]
        public void GetWeightTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama");
            graph.AddNode("Rawan");
            graph.AddEdge("Osama", "Rawan", 100);
            var weight = graph.GetNode("Osama").Neighbors["Rawan"];

            Assert.Equal(100, weight);
        }

        [Fact]
        public void GetSizeTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama");
            graph.AddNode("Rawan");
            Assert.Equal(2, graph.Size());
        }

        [Fact]
        public void NullGraphTest()
        {
            Graph graph = new Graph();
            Assert.Null(graph.GetNodes());
        }
    }
}