using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.ArrayBinarySearch
{
    class ArrayBinarySearch
    {
        public static int BinarySearch(int[] arr, int searchKey)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchKey == arr[mid])
                {
                    return mid;
                }
                else if (searchKey > arr[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }
    }
}
