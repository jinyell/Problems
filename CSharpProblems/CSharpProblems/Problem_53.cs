/*
 * Problem 28: Maximum Subarray
 * Difficulty: Easy
 * 
 * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
 * 
 * Example:
 * Input: [-2,1,-3,4,-1,2,1,-5,4],
 * Output: 6
 * Explanation: [4,-1,2,1] has the largest sum = 6.
 * 
 * Follow up:
 * If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
 */

namespace CSharpProblems
{
    public class Problem_53
    {
        public class Solution
        {
            public int MaxSubArray(int[] nums)
            {
                int maxNum = int.MinValue;
                int maxLast = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    maxLast += nums[i];

                    if (maxNum < maxLast)
                    {
                        maxNum = maxLast;
                    }

                    if (maxLast < 0)
                    {
                        maxLast = 0;
                    }
                }
                return maxNum;
            }
        }
    }
}
