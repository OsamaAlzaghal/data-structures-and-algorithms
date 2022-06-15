using DataStructure.DSA.Hashtable;
using System;
using System.Collections.Generic;

namespace DataStructure.DSA.HashLeftJoin
{
    public class HashtableLeftJoin : HashTable
    {
        public HashtableLeftJoin(int size) : base(size)
        { }

        public static List<string[]> LEFTJOINs(HashTable left, HashTable right)
        {
            if((left == null && right == null) || (left == null)) { return null; }

            if (right == null)
            {
                List<string[]> leftList = new List<string[]>();
                for (int i = 0; i < left.hashtable.Length; i++)
                {
                    TableNode temp = left.hashtable[i];
                    while (temp != null)
                    {
                        leftList.Add(new string[] { $"{temp.Key}", $"{temp.Value}" });
                        temp = temp.Next;
                    }
                }
                return leftList;
            }

            List<string[]> arrayList = new List<string[]>();
            for (int i = 0; i < left.hashtable.Length; i++)
            {
                TableNode temp = left.hashtable[i];
                while (temp != null)
                {
                    if (right.Contains(temp.Key)) { arrayList.Add(new string[] { $"{temp.Key}", $"{temp.Value}", $"{right.Get($"{temp.Key}")}" }); }
                    else { arrayList.Add(new string[] { $"{temp.Key}", $"{temp.Value}", null }); }
                    temp = temp.Next;
                }
            }

            return arrayList;
        }

        public void PrintList(List<string[]> list)
        {
            if (list == null) { Console.WriteLine("List is empty!"); }
            foreach (var array in list)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == null) { Console.Write("NULL"); }
                    Console.Write(array[i]);
                    if (i < array.Length - 1) { Console.Write(", "); }
                }
                Console.Write("] \n");
            }
        }
    }
}