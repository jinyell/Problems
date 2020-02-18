/*
 * Problem 581: Shortest Unsorted Continuous Subarray
 * Difficulty: Easy
 * 
 * Given an integer array, you need to find one continuous subarray that if 
 * you only sort this subarray in ascending order, then the whole array will 
 * be sorted in ascending order, too.
 * 
 * You need to find the shortest such subarray and output its length.
 * 
 * Example 1:
 *      Input: [2, 6, 4, 8, 10, 9, 15]
 *      Output: 5
 *      Explanation: You need to sort [6, 4, 8, 10, 9] in ascending order to 
 * 					 make the whole array sorted in ascending order.
 * 
 * Note:
 *     Then length of the input array is in range [1, 10,000].
 *     The input array may contain duplicates, so ascending order here means <=.
 */

using System;

namespace CSharpProblems
{
    public class Problem_581_Approach_2
    {
        public class Solution
        {
            public int FindUnsortedSubarray(int[] nums)
            {
                int[] snums = new int[nums.Length];
                Array.Copy(nums, snums, nums.Length);
                Array.Sort(snums);
                int start = nums.Length;
                int end = 0;

                for (int i = 0; i < snums.Length; i++)
                {
                    if (snums[i] != nums[i])
                    {
                        start = Math.Min(start, i);
                        end = Math.Max(end, i);
                    }
                }

                return (end - start < 0) ? 0 : end - start + 1;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n log n). Sorting takes n log n time.
 * 		Space complexity : O(n). We are making copy of original array.
 */
