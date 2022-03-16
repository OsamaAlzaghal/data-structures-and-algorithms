using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.ArrayReverse
{
    class ArrayReverse
    {
        public static int[] reverseArray(int[] arr)
        {
            int temp = 0;
            Console.Write("Array before reverse: ");
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            for (int i = 0; i < arr.Length / 2; ++i)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Console.Write("Array after reverse: ");
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            return arr;
        }
    }
}
