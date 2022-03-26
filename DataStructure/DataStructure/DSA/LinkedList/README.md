# Singly Linked List
In this challenge, we were asked to do the implementation of a singly Linked List and some methods that deal with it without utilizing any built-in methods or classes. 

## Challenge

After the implementation of the singly linked list, we have to create some methods such as insert method that inserts a data to the front of the linked list, includes method that returns true if the searched data is found in the linked list and false if it's not found and lastly a method that converts the linked list to a string and return it so we can view all the values in the linked list, formatted as: "[ a ] -> [ b ] -> [ c ] -> NULL".

## Approach & Efficiency
The creation of the Linked List will take O(1) space/time complexity, inserting a data to it will also take O(1) space/time complexity since I only add one node and it's to the front on the linked list, includes method will take O(1) for space complexity and O(n) time complexity to search for a searched data since it has to traverse the whole linked list to check if it's found or not and lastly, the to string method which creates a string representing the linked list values to view them in a formatted string, the time complexity will be O(n) and the space complexity will be O(1).


## API
1. Insert(int data) method that takes an integer value as argument,then creates a new node that holds this value inside it as data and insert it to the front by changing the head poniter to it in a way that keeps the linked list safe from loss.

2. Includes(int data) method that loops through the linked list using a temp pointer to search for a searched data and returns true if it's found, otherwise it returns false. The condition of this loop is to keep iterating until the pointer reaches to null.

3. LinkedListToString() method that returns the data of each node as a formatted string after it concatenates them inside a string using a while loop to traverse the whole linked list.
