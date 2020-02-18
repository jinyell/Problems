/*
 * Problem 594: Longest Harmonious Subsequence
 * Difficulty: Easy
 * 
 * We define a harmounious array as an array where the difference between its 
 * maximum value and its minimum value is exactly 1.
 * 
 * Now, given an integer array, you need to find the length of its longest 
 * harmonious subsequence among all its possible subsequences.
 * 
 * Example 1:
 * 
 *      Input: [1,3,2,2,5,2,3,7]
 *      Output: 5
 *      Explanation: The longest harmonious subsequence is [3,2,2,2,3].
 * 
 * Note: The length of the input array will not exceed 20,000.
 */

using System;
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_594
    {
        public class Solution
        {
            public int FindLHS(int[] nums)
            {
                if (nums == null || nums.Length == 0) { return 0; }

                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dict.ContainsKey(nums[i]))
                    {
                        dict[nums[i]] = 0;
                    }
                    dict[nums[i]]++;
                }

                int longest = 0;
                foreach (var d in dict)
                {
                    longest = Math.Max(longest, (dict.ContainsKey(d.Key + 1) ?
                                    (d.Value + dict[d.Key + 1]) : 0));
                }

                return longest;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). One loop is required to fill map and one for 
 * 						   traversing the map.
 * 		Space complexity : O(n). In the worst case map size grows up to size n
 */
