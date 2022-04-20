using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DSA.Stack_Queue_Brackets
{
    public class StackQueueBrackets
    {
        public static bool ValidateBrackets(string input)
        {
            if(input == "")
            {
                return false;
            }
            string left = "({[";
            string right = ")}]";

            Stack<char> charStack = new Stack<char>();

            foreach (var item in input)
            {
                if (left.Contains(item))
                {
                    charStack.Push(item);
                }
                else if (right.Contains(item))
                {
                    if (charStack.Count < 1)
                    {
                        return false;
                    }
                    /*  This is like if(IndexOf("}") == IndexOf("{")), but it's done for each brackets.
                        My charStack holds all the left brackets, so I just compared if they
                        have the same index, if yes, it means that I could pop and continue, 
                        else I have to return false; because it's not balanced anymore. */

                    if (right.IndexOf(item) != left.IndexOf(charStack.Pop()))
                    {
                        return false;
                    }
                }   
            }
            // If my charStack is empty, it means that I Popped all the elements and it is balanced.
            return charStack.Count == 0;
        }
    }
}