using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.Hashtable;

namespace DataStructure.DSA.Hashtable
{
    public class HashTable
    {
        public int hashTableSize;
        public TableNode[] hashtable;

        /// <summary>
        /// Constructor for the Hashtable.
        /// </summary>
        /// <param name="hashSize"></param>
        public HashTable(int hashSize)
        {
            hashTableSize = hashSize;
            hashtable = new TableNode[hashSize];
        }

        /// <summary>
        /// This method hashes the key, and set the key and value pair in the table,
        /// handling collisions as needed.
        /// a given key already exist, replace its value from the value argument given to this method.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(int key, string value)
        {
            if (key < 0)
            {
                throw new Exception("Key value is negative and it's not allowed.");
            }
                
            int hashedKey = Hash(key);
            if (hashtable[hashedKey] == null)
            {
                hashtable[hashedKey] = new TableNode(key, value);
            }
            else
            {
                // If we have a collision, we add the new item to the back of a specific node.
                TableNode temp = hashtable[hashedKey];
                // If our value is at the first index, we iterate only once so that the complexity
                // is O(1), otherwise it will be O(n).
                while (temp.Next != null || temp.Key == key)
                {
                    // If we want to change the value of an item we already have, just overwrite it.
                    if (temp.Key == key)
                    {
                        temp.Value = value;
                        return;
                    }

                    temp = temp.Next;
                }
                // Set the pointer for our added item that it's key causes a collision.
                temp.Next = new TableNode(key, value);
            }
        }

        /// <summary>
        /// Get method for a specific key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Value associated with that key in the table </returns>
        public string Get(int key)
        {
            if (!Contains(key))
            {
                return null;
            }

            int hashedKey = Hash(key);

            TableNode temp = hashtable[hashedKey];
            while (temp.Key != key)
            {
                temp = temp.Next;
            }

            return temp.Value;
        }

        /// <summary>
        /// A method that indicates if the key exists in the table already.
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Boolean </returns>
        public bool Contains(int key)
        {
            int hashedKey = Hash(key);
            TableNode temp = hashtable[hashedKey];
            while (temp != null)
            {
                if (temp.Key == key)
                    return true;

                temp = temp.Next;
            }
            return false;
        }
        
        /// <summary>
        /// A method that adds all the keys in the HashTable in a list.
        /// </summary>
        /// <returns> A list of keys </returns>
        public List<int> Keys()
        {
            // Empty list that will hold ours keys.
            List<int> keys = new List<int>();
            // Add all the items that are not null.
            List<TableNode> items = hashtable.Where(x => x != null).ToList();
            // Loop over the list and add the key for each item in the HashTable.
            foreach (TableNode node in items)
            {
                if (node.Next == null)
                {
                    keys.Add(node.Key);
                }
                else
                {
                    TableNode temp = node;
                    while (temp != null)
                    {
                        keys.Add(temp.Key);
                        temp = temp.Next;
                    }
                }
            }
            return keys;
        }

        /// <summary>
        /// Our simple hashing method that returns.
        /// </summary>
        /// <param name="key"></param>
        /// <returns> the index for a single item. </returns>
        public int Hash(int key)
        {
            return key % hashTableSize;
        }
    }
}