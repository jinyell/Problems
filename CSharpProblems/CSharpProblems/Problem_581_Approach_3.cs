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
    public class Problem_581_Approach_3
    {
        public class Solution
        {
            public int FindUnsortedSubarray(int[] nums)
            {
                int min = int.MaxValue;
                int max = int.MinValue;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        min = Math.Min(min, nums[i + 1]);
                    }
                }

                for (int i = nums.Length - 1; i > 0; i--)
                {
                    if (nums[i - 1] > nums[i])
                    {
                        max = Math.Max(max, nums[i - 1]);
                    }
                }

                int left = 0;
                int right = nums.Length - 1;

                for (; left < nums.Length; left++)
                {
                    if (min < nums[left]) { break; }
                }

                for (; right >= 0; right--)
                {
                    if (max > nums[right]) { break; }
                }

                return (right < left) ? 0 : right - left + 1;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Four O(n) loops are used.
 * 		Space complexity : O(1). Constant space is used.
 */
