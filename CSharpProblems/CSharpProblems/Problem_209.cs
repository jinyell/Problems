/*
 * Problem 209: Minimum Size Subarray Sum
 * Difficulty: Medium
 * 
 * Given an array of n positive integers and a positive integer s, find the 
 * minimal length of a contiguous subarray of which the sum ≥ s. If there 
 * isn't one, return 0 instead.
 * 
 * Example: 
 *      Input: s = 7, nums = [2,3,1,2,4,3]
 *      Output: 2
 *      Explanation: the subarray [4,3] has the minimal length under the 
 * 					 problem constraint.
 * 
 * Follow up: If you have figured out the O(n) solution, try coding another 
 * 			  solution of which the time complexity is O(n log n). 
 */

using System;

namespace CSharpProblems
{
    public class Problem_209
    {
        public class Solution
        {
            public int MinSubArrayLen(int s, int[] nums)
            {
                int result = int.MaxValue;
                int left = 0;
                int sum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    while (sum >= s)
                    {
                        result = Math.Min(result, (i + 1) - left);
                        sum -= nums[left++];
                    }
                }
                return (result != int.MaxValue) ? result : 0;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Each element can be visited almost twice, 
 * 			once by the right pointer (i) and (atmost) once by the left pointer.
 * 		Space complexity : O(1) extra space. Only constant space required for 
 * 			left, sum, ans, and i.
 */
