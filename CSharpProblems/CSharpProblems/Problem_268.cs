/*
 * Problem 268: Missing Number
 * Difficulty: Easy
 * 
 * Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, 
 * find the one that is missing from the array.
 * 
 * Example 1:
 *      Input: [3,0,1]
 *      Output: 2
 * 
 * Example 2:
 *      Input: [9,6,4,2,3,5,7,0,1]
 *      Output: 8
 * 
 * Note: Your algorithm should run in linear runtime complexity. Could you 
 * 		 implement it using only constant extra space complexity?
 */

namespace CSharpProblems
{
    public class Problem_268
    {
        public class Solution
        {
            public int MissingNumber(int[] nums)
            {
                int expectedSum = (nums.Length * (nums.Length + 1)) / 2;
                int actualSum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    actualSum += nums[i];
                }

                return expectedSum - actualSum;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(n) Although Gauss' formula can be computed O(1) 
 * 						  time, summing nums cost us O(n) time, so the 
 * 						  algorithm overall is linear.
 * 		Space complexity: O(1). This approach only pushes a few integers 
 * 						  around, so it has constant memory usage.
 */
