# Trees
A tree is non-linear and a hierarchical data structure consisting of a collection of nodes such that each node of the tree stores a value, a list of references to nodes (the “children”).
### Tree components
+ Node - A Tree node is a component which may contain its own values, and references to other nodes.
+ Root - The root is the node at the beginning of the tree.
+ K - A number that specifies the maximum number of children any node may have in a k-ary tree. In a binary tree, k = 2.
+ Left - A reference to one child node, in a binary tree.
+ Right - A reference to the other child node, in a binary tree.
+ Edge - The edge in a tree is the link between a parent and child node.
+ Leaf - A leaf is a node that does not have any children
+ Height - The height of a tree is the number of edges from the root to the furthest leaf.

### Traversals
1. Depth First: Depth first traversal is where we prioritize going through the depth (height) of the tree first.

	Methods for depth first traversal:
	+ Pre-order: root >> left >> right
	+ In-order: left >> root >> right
	+ Post-order: left >> right >> root
	
2. Breadth First: It starts at the tree root and explores all nodes at the present depth prior to moving on to the nodes at the next depth level. Breadth first traversal uses a queue (instead of the call stack via recursion) to traverse the width/breadth of the tree.

---
## Challenge
<!-- Description of the challenge -->
Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.

Create a Binary Tree class: 
+ Define a method for each of the depth first 	traversals:
+ Pre order
+ In order
+ Post order which returns an array of the values, ordered appropriately.

Create a Binary Search Tree class:
+ This class should be a sub-class (or your languages equivalent) of the Binary Tree Class, with the following additional methods:
+ Add: Arguments: value, Return: nothing, and adds a new node with that value in the correct location in the binary search tree.
+ Contains: Argument: value, Returns: boolean indicating whether or not the value is in the tree at least once.

---
## Approach & Efficiency
All my traversal methods, add, and containts have a time complexity of O(n); because I used a while loop that iterates n time. For the space complexity, my traversals are O(n); because they return a new list that have all my values, add and contains methods are O(1) for space.

---
## API
1. PreOrder: returns a list of elements ordered by the pre order way.
2. InOrder: returns a list of elements ordered by the in order way.
3. PostOrder: returns a list of elements ordered by the post order way.
4. Containts: returns bool that indicates whether or not the value is in the tree at least once.
5. Add: adds a new node to a Binary Search Tree in the correct location.