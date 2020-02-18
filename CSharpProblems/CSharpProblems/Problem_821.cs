/*
 * Problem 821: Shortest Distance to a Character
 * Difficulty: Easy
 * 
 * Given a string S and a character C, return an array of integers 
 * representing the shortest distance from the character C in the string.
 * 
 * Example 1:
 * 
 * Input: S = "loveleetcode", C = 'e'
 * Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
 * 
 * Note:
 *     S string length is in [1, 10000].
 *     C is a single character, and guaranteed to be in string S.
 *     All letters in S and C are lowercase
 */

using System;

namespace CSharpProblems
{
    public class Problem_821
    {
        public class Solution
        {
            public int[] ShortestToChar(string S, char C)
            {
                int[] ans = new int[S.Length];
                int prev = int.MinValue / 2;

                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] == C)
                    {
                        prev = i;
                    }
                    ans[i] = i - prev;
                }

                prev = int.MaxValue / 2;
                for (int i = S.Length - 1; i >= 0; i--)
                {
                    if (S[i] == C)
                    {
                        prev = i;
                    }
                    ans[i] = Math.Min(ans[i], prev - i);
                }

                return ans;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the length of S. We scan through 
 * 						   the string twice.
 * 		Space complexity : O(N), the size of ans
 */
