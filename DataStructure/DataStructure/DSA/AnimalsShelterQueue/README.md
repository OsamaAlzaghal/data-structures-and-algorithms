# Challenge Summary
Create a class called AnimalShelter which holds only dogs and cats, the shelter operates using a first-in, first-out approach, and it has two methods which are enqueue and dequeue.

## Whiteboard Process
<!-- Embedded whiteboard image -->

## Approach & Efficiency
I used two built-in Queues and their methods to do my operations. The time complexity for Enqueue method is O(1) and for Dequeue method is O(n). The space complexity for both Enqueue and Dequeue is O(1).

## Solution
You can run my project by downloading the project folder, then open the solution file and press Ctrl + F5 or run button to run my code.

Code:
```
// Enqueue method
public void Enqueue(Animal animal)
        {
            Animals.Enqueue(animal);
        }

// Dequeue method
public Animal Dequeue(string type)
        {
            try
            {
                if (Animals.Count < 1)
                {
                    throw new Exception("The queue is empty!");
                }
                else
                {
                    Animal temp;
                    while (Animals.Count > 0)
                    {
                        temp = Animals.Peek();
                        if (temp.Type == type)
                        {
                            break;
                        }
                        else
                        {
                            TempQueue.Enqueue(Animals.Dequeue());
                        }
                    }
                    if (Animals.Count > 0)
                    {
                        temp = Animals.Dequeue();
                        while (Animals.Count > 0)
                        {
                            TempQueue.Enqueue(Animals.Dequeue());
                        }
                        while (TempQueue.Count > 0)
                        {
                            Animals.Enqueue(TempQueue.Dequeue());
                        }
                        return temp;
                    }
                    else
                    {
                        while (TempQueue.Count > 0)
                        {
                            Animals.Enqueue(TempQueue.Dequeue());
                        }
                        return null;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

```