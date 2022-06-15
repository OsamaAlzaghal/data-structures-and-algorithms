using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.Hashtable
{
    public class TableNode
    {
        public string Key;
        public string Value;
        public TableNode Next;

        /// <summary>
        /// Constructor to set the key and value for each item that we add in the HashTable.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public TableNode(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}