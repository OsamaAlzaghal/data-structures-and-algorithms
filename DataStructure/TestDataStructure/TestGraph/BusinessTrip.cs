using DataStructure.DSA.Graph_Implementation;
using Xunit;

namespace TestDataStructure.TestGraph
{
    public class BusinessTrip
    {
        [Fact]
        public void EmptyGraphTest()
        {
            Graph graph = new Graph();
            Assert.Null(graph.BusinessTrip(null, new string[] { "Osama", "Rawan" }));

        }

        [Fact]
        public void EmptyArrayTest()
        {
            Graph graph = new Graph();
            Assert.Null(graph.BusinessTrip(graph, null));
        }

        [Fact]
        public void OneCityTest()
        {
            Graph graph = new Graph();
            Assert.Null(graph.BusinessTrip(graph, new string[] { "Amman" }));
        }

        [Fact]
        public void UnvalidVertextTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama"); graph.AddNode("Rawan"); graph.AddNode("Ali");
            graph.AddEdge("Osama", "Ali", 10);
            graph.AddEdge("Ali", "Rawan", 10);
            Assert.Null(graph.BusinessTrip(graph, new string[] { "Ahmad", "Rawan" }));
        }

        [Fact]
        public void ValidTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama"); graph.AddNode("Rawan"); graph.AddNode("Ali");
            graph.AddEdge("Osama", "Ali", 10);
            graph.AddEdge("Ali", "Rawan", 10);
            Assert.Equal(20, graph.BusinessTrip(graph, new string[] { "Osama", "Ali", "Rawan" }));
        }

        [Fact]
        public void NoPathTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Osama"); graph.AddNode("Rawan"); graph.AddNode("Ali");
            graph.AddEdge("Osama", "Ali", 10);
            graph.AddEdge("Ali", "Rawan", 10);
            Assert.Null(graph.BusinessTrip(graph, new string[] { "Osama", "Rawan" }));
        }
    }
}
