﻿/*
 * Problem 171: Excel Sheet Column Number
 * Difficulty: Easy
 * 
 * Given a column title as appear in an Excel sheet, return its corresponding 
 * column number.
 * 
 * For example:
 *     A -> 1
 *     B -> 2
 *     C -> 3
 *     ...
 *     Z -> 26
 *     AA -> 27
 *     AB -> 28 
 *     ...
 * 
 * Example 1:
 *      Input: "A"
 *      Output: 1
 * 
 * Example 2:
 *      Input: "AB"
 *      Output: 28
 * 
 * Example 3:
 *      Input: "ZY"
 *      Output: 701
 */

namespace CSharpProblems
{
    public class Problem_171
    {
        public class Solution
        {
            public int TitleToNumber(string s)
            {
                int res = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    res = res * 26 + (s[i] - 'A' + 1);
                }

                return res;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
