# Graphs
## What is a Graph?
A graph is a non-linear data structure that can be looked at as a collection of vertices (or nodes) potentially connected by line segments named edges.


## Graph terminologies:
+ Vertex - A vertex, also called a “node”, is a data object that can have zero or more adjacent vertices.
+ Edge - An edge is a connection between two nodes.
+ Neighbor - The neighbors of a node are its adjacent nodes, i.e., are connected via an edge.
+ Degree - The degree of a vertex is the number of edges connected to that vertex.


## Directed Graphs (Digraph)
A Directed Graph also called a Digraph is a graph where every edge is directed.

Unlike an undirected graph, a Digraph has direction. Each node is directed at another node with a specific requirement of what node should be referenced next.


## Undirected Graphs
An Undirected Graph is a graph where each edge is undirected or bi-directional. This means that the undirected graph does not move in any direction.

---

## Challenge 35
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

+ add node.
+ add edge.
+ get nodes.
+ get neighbors.
+ size.

---

## Approach & Efficiency

I created a Node class and a Graph class. My graph class a HashSet of Nodes and each node has another HashSet that represents the neighbors for that node along with other properties I added for the node itself. 

Space/Time complexity:
	+ Space: I'll add it after I get the answer.  
	+ Time: It runs in O(1) expected time; because as any hash table, It is backed by a HashMap where the key is the Object, so that I can get or add values directly.

---

## API
My Graph class includes the following methods:

+ AddNode()
	+ Arguments: value.
	+ Returns: The added node.
	+ Add a node to the graph .
+ AddEdge()
	+ Arguments: 2 nodes to be connected by the edge, weight (optional).
	+ Returns: nothing.
	+ Adds a new edge between two nodes in the graph.
	+ If specified, assign a weight to the edge.
	+ Both nodes should already be in the Graph.
+ GetNodes()
	+ Arguments: none.
	+ Returns all of the nodes in the graph as a collection (set, list, or similar).
+ GetNeighbors()
	+ Arguments: node.
	+ Returns a collection of edges connected to the given node.
	+ Include the weight of the connection in the returned collection.
+ Size()
	+ Arguments: none.
	+ Returns the total number of nodes in the graph.
	
Graph Class:
```
public class Graph
    {
        public readonly HashSet<Node> vertexSet;
        protected readonly bool Directed;

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

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public HashSet<Node> GetNodes()
        {
            if(this.vertexSet.Count == 0) { return null; }
            return this.vertexSet;
        }

        public Node GetNode(string value)
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
```


**Note:** I have created a Node class that holds other helper methods.

```
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
```