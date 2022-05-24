# Challenge 26
Implementation of Insertion Sort. 
+ Provide a visual step through for each of the sample arrays based on the provided pseudo code. 
+ Convert the pseudo-code into working code in your language. 
+ Present a complete set of working tests

---
## Whiteboard Process
![insertion-sort](insertion-sort.png)

---
## Approach & Efficiency
Selection Sort is a sorting algorithm that traverses the array multiple times as it slowly builds out the sorting sequence. The traversal keeps track of the minimum value and places it in the front of the array which should be incrementally sorted.
+ Time: O(n^2):
The basic operation of this algorithm is comparison. This will happen n * (n-1) number of times…concluding the algorithm to be n squared.
+ Space: O(1): No additional space is being created. This array is being sorted in place…keeping the space at constant O(1).

---
## Solution

```
public static void InsertionSortMethod(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
```