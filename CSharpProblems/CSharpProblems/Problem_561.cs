/*
 * Problem 561: Array Partition I
 * Difficulty: Easy
 * 
 * Given an array of 2n integers, your task is to group these integers into 
 * n pairs of integer, say (a1, b1), (a2, b2), ..., (an, bn) which makes sum 
 * of min(ai, bi) for all i from 1 to n as large as possible.
 * 
 * Example 1:
 *      Input: [1,4,3,2]
 *      Output: 4
 *      Explanation: n is 2, and the maximum sum of pairs is 
 * 					 4 = min(1, 2) + min(3, 4).
 * 
 * Note:
 *     n is a positive integer, which is in the range of [1, 10000].
 *     All the integers in the array will be in the range of [-10000, 10000].
 */

using System;

namespace CSharpProblems
{
    public class Problem_561
    {
        public class Solution
        {
            public int ArrayPairSum(int[] nums)
            {
                Array.Sort(nums);
                int startIndex = 0;
                int endIndex = nums.Length - 2;
                int mid = nums.Length / 2;
                int result = 0;
                bool odd = false;

                if (mid % 2 == 1)
                {
                    odd = true;
                }

                while (startIndex < endIndex)
                {
                    result += nums[startIndex];
                    result += nums[endIndex];
                    startIndex += 2;
                    endIndex -= 2;
                }

                if (odd)
                {
                    result += nums[startIndex];
                }

                return result;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
