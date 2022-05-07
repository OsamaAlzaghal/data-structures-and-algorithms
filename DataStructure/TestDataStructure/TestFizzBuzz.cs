using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.DSA.FizzBuzz;
using Xunit;

namespace TestDataStructure
{
    public class TestFizzBuzz
    {
        [Fact]
        public void TestFizzBuzzConversion()
        {
            FizzBuzzTree buzzTree = new FizzBuzzTree("1");
            buzzTree.Children.Add(new FizzBuzzTree("2"));
            buzzTree.Children.Add(new FizzBuzzTree("3"));
            buzzTree.Children.Add(new FizzBuzzTree("4"));
            buzzTree.Children[0].Children.Add(new FizzBuzzTree("5"));
            buzzTree.Children[0].Children.Add(new FizzBuzzTree("6"));
            buzzTree.Children[0].Children.Add(new FizzBuzzTree("7"));

            List<string> list1 = buzzTree.FizzBuzz(buzzTree);
            List<string> list2 = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" };
            Assert.Equal(list2, list1);
        }
    }
}