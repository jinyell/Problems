/*
 * Problem 20: Valid Parentheses
 * Difficulty: Easy
 * 
 * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 * An input string is valid if:
 * 
 *     Open brackets must be closed by the same type of brackets.
 *     Open brackets must be closed in the correct order.
 * 
 * Note that an empty string is also considered valid.
 * 
 * Example 1:
 * Input: "()"
 * Output: true
 * 
 * Example 2:
 * Input: "()[]{}"
 * Output: true
 * 
 * Example 3:
 * Input: "(]"
 * Output: false
 * 
 * Example 4:
 * Input: "([)]"
 * Output: false
 * 
 * Example 5:
 * Input: "{[]}"
 * Output: true
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_20_Approach_2
    {
        public class Solution
        {
            public bool IsValid(string s)
            {
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        stack.Push(')');
                    }
                    else if (s[i] == '{')
                    {
                        stack.Push('}');
                    }
                    else if (s[i] == '[')
                    {
                        stack.Push(']');
                    }
                    else if (stack.Count == 0 || stack.Pop() != s[i])
                    {
                        return false;
                    }
                }

                return stack.Count == 0;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
