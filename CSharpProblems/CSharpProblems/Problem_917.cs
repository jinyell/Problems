/*
 * Problem 917: Reverse Only Letters
 * Difficulty: Easy
 * 
 * Given a string S, return the "reversed" string where all characters that 
 * are not a letter stay in the same place, and all letters reverse their 
 * positions.
 * 
 * Example 1:
 *      Input: "ab-cd"
 *      Output: "dc-ba"
 * 
 * Example 2:
 *      Input: "a-bC-dEf-ghIj"
 *      Output: "j-Ih-gfE-dCba"
 * 
 * Example 3:
 *      Input: "Test1ng-Leet=code-Q!"
 *      Output: "Qedo1ct-eeLg=ntse-T!"
 * 
 * Note:
 *     S.length <= 100
 *     33 <= S[i].ASCIIcode <= 122 
 *     S doesn't contain \ or "
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems
{
    public class Problem_917
    {
        public class Solution
        {
            public string ReverseOnlyLetters(string S)
            {
                Stack<char> letters = new Stack<char>();

                for (int i = 0; i < S.Length; i++)
                {
                    if (Char.IsLetter(S[i]))
                    {
                        letters.Push(S[i]);
                    }
                }

                StringBuilder result = new StringBuilder();
                for (int i = 0; i < S.Length; i++)
                {
                    if (Char.IsLetter(S[i]))
                    {
                        result.Append(letters.Pop());
                    }
                    else
                    {
                        result.Append(S[i]);
                    }
                }

                return result.ToString();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the length of S
 * 		Space complexity : O(N)
 */
