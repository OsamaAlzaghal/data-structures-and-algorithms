using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.Sorting.Merge
{
    public class MergeSort
    {
        public static int[] MergesortMethod(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int mid = n / 2;
                // Take(): returns the specified number of elements starting from the first element.
                int[] left = arr.Take(mid).ToArray();
                // Skip(): skips the specified number of element starting from first element and returns rest of the elements.
                int[] right = arr.Skip(mid).ToArray();
                MergesortMethod(left);
                MergesortMethod(right);
                Merge(left, right, arr);
            }
            return arr;
        }

        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }

            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length - 1; i++) { Console.Write(arr[i] + ", "); }
            Console.Write(arr[arr.Length - 1] + " ]");
        }
    }
}
