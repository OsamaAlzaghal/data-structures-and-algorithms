using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructure.DSA.Hashtable;

namespace TestDataStructure
{
    public class TestHashTable
    {
        [Fact]
        public void TestkeyValue()
        {
            HashTable table = new HashTable(25);
            table.Set("5", "13");
            Assert.Equal("13", table.Get("5"));
        }

        [Fact]
        public void TestNullKeys()
        {
            HashTable table = new HashTable(10);
            Assert.Null(table.Get("7"));
        }

        [Fact]
        public void TestUniquekeys()
        {
            HashTable table = new HashTable(10);
            table.Set("1", "1");
            table.Set("2", "2");
            table.Set("3", "3");
            List<string> keys = new List<string>();
            keys.Add("1");
            keys.Add("2");
            keys.Add("3");
            Assert.Equal(keys, table.Keys());
        }

        [Fact]
        public void TestCollisions()
        {
            HashTable table = new HashTable(7);
            table.Set("1", "65");
            table.Set("8", "75");
            Assert.Equal("65", table.Get("1"));
            Assert.Equal("75", table.Get("8"));
        }

        [Fact]
        public void TestKeyInRangeValue()
        {
            HashTable table = new HashTable(100);
            string key = "234";
            Assert.True(table.Hash(key) < 100 && table.Hash(key) > 0);
        }
    }
}