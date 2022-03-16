using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.ArrayShift
{
    class ArrayShift
    {
        public static int[] insertShiftArray(int[] arr, int number)
        {
            int[] newArr;
            if (arr.Length == 1)
            {
                newArr = new int[arr.Length + 1];
                newArr[0] = arr[0];
                newArr[1] = number;
                return newArr;
            }

            newArr = new int[arr.Length + 1];
            int middle = newArr.Length / 2;

            for (int i = 0; i < middle; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[middle] = number;

            for (int i = middle + 1; i < newArr.Length; i++)
            {
                newArr[i] = arr[i - 1];
            }
            return newArr;
        }
    }
}
