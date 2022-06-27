using DataStructure.DSA.Graph_Implementation;
using System.Collections.Generic;
using Xunit;


namespace TestDataStructure.TestGraph
{
    public class BreadthFirst
    {
        [Fact]
        public void TraversalTest()
        {
            Graph graph = new Graph();
            graph.AddNode("Pandora"); graph.AddNode("Arendelle"); graph.AddNode("Metroville");
            graph.AddNode("Monstroplolis"); graph.AddNode("Narnia"); graph.AddNode("Naboo");

            graph.AddEdge("Pandora", "Arendelle", 10); graph.AddEdge("Arendelle", "Metroville", 10);
            graph.AddEdge("Arendelle", "Monstroplolis", 10); graph.AddEdge("Metroville", "Narnia", 10);
            graph.AddEdge("Metroville", "Naboo", 10); graph.AddEdge("Naboo", "Narnia", 10);
            graph.AddEdge("Monstroplolis", "Naboo", 10); graph.AddEdge("Monstroplolis", "Metroville", 10);

            // Output: Pandora, Arendelle, Metroville, Monstroplolis, Narnia, Naboo.
            List<string> names = new List<string>();
            foreach (var item in graph.BreadthFirst("Pandora")) { names.Add(item.Value); }
            Assert.Equal(new List<string> { "Pandora", "Arendelle", "Metroville", "Monstroplolis", "Narnia", "Naboo" }, names);
        }

        [Fact]
        public void EmptyGraphTest()
        {
            Graph graph = new Graph();
            Assert.Null(graph.BreadthFirst("Pandora"));
        }
    }
}
