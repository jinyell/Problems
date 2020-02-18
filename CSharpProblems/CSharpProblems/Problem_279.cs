/*
 * Problem 279: Perfect Squares
 * Difficulty: Medium
 * 
 * Given a positive integer n, find the least number of perfect square numbers 
 * (for example, 1, 4, 9, 16, ...) which sum to n.
 * 
 * Example 1:
 *      Input: n = 12
 *      Output: 3 
 *      Explanation: 12 = 4 + 4 + 4.
 * 
 * Example 2:
 *      Input: n = 13
 *      Output: 2
 *      Explanation: 13 = 4 + 9.
 */

using System;

namespace CSharpProblems
{
    public class Problem_279
    {
        public class Solution
        {
            public int NumSquares(int n)
            {
                int[] record = new int[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    record[i] = i;
                    for (int j = 1; (j * j) <= i; j++)
                    {
                        record[i] = Math.Min(record[i - (j * j)] + 1, record[i]);
                    }
                }
                return record[n];
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : 
 * 		Space complexity: 
 */
