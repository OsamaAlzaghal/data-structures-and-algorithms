using DataStructure.DSA.Stack_Queue_Brackets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;



namespace TestDataStructure
{
    public class TestValidateBrackets
    {
        [Fact]
        public void TestBalancedBrackets()
        {
            Assert.True(StackQueueBrackets.ValidateBrackets("({[]})"));
            Assert.True(StackQueueBrackets.ValidateBrackets("{}"));
            Assert.True(StackQueueBrackets.ValidateBrackets("{}(){}"));
            Assert.True(StackQueueBrackets.ValidateBrackets("()[[Extra Characters]]"));
            Assert.True(StackQueueBrackets.ValidateBrackets("(){}[[]]"));
            Assert.True(StackQueueBrackets.ValidateBrackets("{}{Code}[Fellows](())"));
        }

        [Fact]
        public void TestNotBalancedBrackets()
        {
            Assert.False(StackQueueBrackets.ValidateBrackets("(]("));
            Assert.False(StackQueueBrackets.ValidateBrackets("[({}]"));
            Assert.False(StackQueueBrackets.ValidateBrackets("{(})"));
            Assert.False(StackQueueBrackets.ValidateBrackets(""));
        }
    }
}
