using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructure.DSA.HashmapRepeatedWord;

namespace TestDataStructure
{
    public class TestHashmap
    {
        [Fact]
        public void TestEmptyString()
        {
            Assert.Null(Hashmap.RepeatedWord(""));
        }

        [Fact]
        public void TestRepeatedWords()
        {
            string test1 = "Once upon a time, there was a brave princess who...";
            string test2 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            // This should return "a".
            Assert.Equal("a", Hashmap.RepeatedWord(test1));
            // This should return "summer".
            Assert.Equal("summer", Hashmap.RepeatedWord(test2));
        }

        [Fact]
        public void TestNoRepeatedWords()
        {
            Assert.Null(Hashmap.RepeatedWord("Hello! my name is osama alzaghal."));
        }
    }
}
