# Stacks and Queues
## What is a stack?
Stack is a container of objects that are inserted and removed according to the last-in first-out (LIFO) principle. First, we need to create a class for stack to instantiate an object, then it can be implemented using the Node class or any as long as the used methods apply the principles of stack, so that each element inside a stack is a node.

## What is a queue?
Queue is a container of objects (a linear collection) that are inserted and removed according to the first-in first-out (FIFO) principle. First, we need to create a class for queue to instantiate an object, then it can be implemented using the Node class or any as long as it applies the principles of queue, so that each element inside a queue is a node.

![StacksAndQueues](https://miro.medium.com/max/1400/1*zKnDkJpL-4GQ36kzrDiODQ.png)

---
## Challenge
### Node class:
Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.

### Stack class:
+ Create a Stack class that has a top property. It creates an empty Stack when instantiated.
	+ This object should be aware of a default empty value assigned to top when the stack is created.
	+ The class should contain the following methods:
+ push
	+ Arguments: value
	+ adds a new node with that value to the top of the stack with an O(1) Time performance.
+ pop
	+ Arguments: none
	+ Returns: the value from node from the top of the stack
	+ Removes the node from the top of the stack
	+ Should raise exception when called on empty stack
+ peek
	+ Arguments: none
	+ Returns: Value of the node located at the top of the stack
	+ Should raise exception when called on empty stack
+ is empty
	+ Arguments: none
	+ Returns: Boolean indicating whether or not the stack is empty.
---
### Queue class:
+ Create a Queue class that has a front property. It creates an empty Queue when instantiated.
	+ This object should be aware of a default empty value assigned to front when the queue is created.
	+ The class should contain the following methods:
	+ enqueue
		+ Arguments: value
		+ adds a new node with that value to the back of the queue with an O(1) Time performance.
	+ dequeue
		+ Arguments: none
		+ Returns: the value from node from the front of the queue
		+ Removes the node from the front of the queue
		+ Should raise exception when called on empty queue
	+ peek
		+ Arguments: none
		+ Returns: Value of the node located at the front of the queue
		+ Should raise exception when called on empty stack
	+ is empty
		+ Arguments: none
		+ Returns: Boolean indicating whether or not the queue is empty

---
## Approach & Efficiency
For all the methods, space complexity is O(1), and for the time complexity is also a O(1).

---
## API
### Stack methods:
+ Push: takes a value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.
+ Pop: removes the node and returns the node's value from the top of the stack.
+ Peek: returns value of the node located at the top of the stack.
+ IsEmpty: returns a boolean indicating whether or not the stack is empty.

### Queue methods:
+ Enqueue: adds a new node with that value to the back of the queue with an O(1) Time performance.
+ Dequeue Returns: the value from node from the front of the queue.
+ Peek: returns value of the node located at the front of the queue.
+ IsEmpty returns a boolean indicating whether or not the queue is empty.

**Note:** for both stacks and queues, if you try to access something that is null, it will raise an exception and return null.