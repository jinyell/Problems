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

using System;
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_20
    {
        public class Solution
        {
            public bool IsValid(string s)
            {
                if (String.IsNullOrEmpty(s))
                {
                    return true;
                }

                Stack<char> stack = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (stack.Count == 0 || IsLeftParentheses(s[i]))
                    {
                        stack.Push(s[i]);
                        continue;
                    }

                    if (Match(stack.Peek(), s[i]))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                return stack.Count == 0;
            }

            private bool IsLeftParentheses(char check)
            {
                return (check == '[' || check == '{' || check == '(');
            }

            private bool Match(char left, char right)
            {
                return (left == '[' && right == ']') || (left == '{' && right == '}') || (left == '(' && right == ')');
            }
        }
    }
}
