/*
 * Problem 696: Count Binary Substrings
 * Difficulty: Easy
 * 
 * Give a string s, count the number of non-empty (contiguous) substrings 
 * that have the same number of 0's and 1's, and all the 0's and all the 1's 
 * in these substrings are grouped consecutively.
 * 
 * Substrings that occur multiple times are counted the number of times 
 * they occur.
 * 
 * Example 1:
 *      Input: "00110011"
 *      Output: 6
 *      Explanation: There are 6 substrings that have equal number of 
 * 		consecutive 1's and 0's: "0011", "01", "1100", "10", "0011", and "01".
 * 
 * Notice that some of these substrings repeat and are counted the number 
 * of times they occur.
 * 
 * Also, "00110011" is not a valid substring because all the 0's (and 1's) 
 * are not grouped together.
 * 
 * Example 2:
 *      Input: "10101"
 *      Output: 4
 *      Explanation: There are 4 substrings: "10", "01", "10", "01" that have 
 * 					 equal number of consecutive 1's and 0's.
 * 
 * Note:
 *      - s.length will be between 1 and 50,000.
 *      - s will only consist of "0" or "1" characters.
 */

using System;

namespace CSharpProblems
{
    public class Problem_696
    {
        public class Solution
        {
            public int CountBinarySubstrings(string s)
            {
                int ans = 0;
                int prev = 0;
                int curr = 1;

                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i - 1] != s[i])
                    {
                        ans += Math.Min(prev, curr);
                        prev = curr;
                        curr = 1;
                    }
                    else
                    {
                        curr++;
                    }
                }
                return ans + Math.Min(prev, curr);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the length of s. Every loop is 
 * 						through O(N) items with O(1) work inside the for-block.
 * 		Space complexity : O(1), the space used by prev, cur, and ans
 */
