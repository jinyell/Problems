/*
 * Problem 3: Longest Substring Without Repeating Characters
 * Difficulty: Medium
 * 
 * Given a string, find the length of the longest substring without 
 * repeating characters.
 * 
 * Example 1:
 *      Input: "abcabcbb"
 *      Output: 3 
 *      Explanation: The answer is "abc", with the length of 3. 
 * 
 * Example 2:
 *      Input: "bbbbb"
 *      Output: 1
 *      Explanation: The answer is "b", with the length of 1.
 * 
 * Example 3:
 *      Input: "pwwkew"
 *      Output: 3
 *      Explanation: The answer is "wke", with the length of 3. 
 *              	 Note that the answer must be a substring, "pwke" is a 
 * 					 subsequence and not a substring.
 */

using System;
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_3
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                HashSet<char> hs = new HashSet<char>();
                int slow = 0;
                int fast = 0;
                int max = 0;
                while (fast < s.Length)
                {
                    if (!hs.Contains(s[fast]))
                    {
                        hs.Add(s[fast++]);
                        max = Math.Max(max, hs.Count);
                    }
                    else
                    {
                        hs.Remove(s[slow++]);
                    }
                }
                return max;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(2n) = O(n). In the worst case each character 
 * 						  will be visited by i and j.
 * 		Space complexity: O(min(m,n)). Same as the previous approach. We 
 * 						  need O(k) space for the sliding window, where k is 
 * 						  the size of the Set. The size of the Set is upper 
 * 						  bounded by the size of the string n and the size 
 * 						  of charset/alphabet m.
 */
