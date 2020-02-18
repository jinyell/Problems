﻿/*
 * Problem 287: Find the Duplicate Number
 * Difficulty: Medium
 *
 * Given an array nums containing n + 1 integers where each integer is 
 * between 1 and n (inclusive), prove that at least one duplicate 
 * number must exist. Assume that there is only one duplicate number, 
 * find the duplicate one.
 * 
 * Example 1:
 *      Input: [1,3,4,2,2]
 *      Output: 2
 * 
 * Example 2:
 *      Input: [3,1,3,4,2]
 *      Output: 3
 * 
 * Note:
 *     - You must not modify the array (assume the array is read only).
 *     - You must use only constant, O(1) extra space.
 *     - Your runtime complexity should be less than O(n2).
 *     - There is only one duplicate number in the array, but it could be 
 * 		 repeated more than once.
 */

using System;

namespace CSharpProblems
{
    public class Problem_287_Approach_3
    {
        public class Solution
        {
            public int FindDuplicate(int[] nums)
            {
                Array.Sort(nums);

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == nums[i - 1])
                    {
                        return nums[i];
                    }
                }

                return -1;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : O(nlgn). The sort invocation costs O(nlgn) time in 
 * 						  Python and Java, so it dominates the subsequent 
 * 						  linear scan.
 * 		Space complexity: O(1) or O(n). Here we sort nums in place, so the 
 * 						  memory footprint is constant. If we cannot modify 
 * 						  the input array, then we must allocate linear space 
 * 						  for a copy of nums and sort that instead.
 */
