﻿/*
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
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_581_Approach_4
    {
        public class Solution
        {
            public int FindUnsortedSubarray(int[] nums)
            {
                Stack<int> stack = new Stack<int>();
                int left = nums.Length;
                int right = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    while (stack.Count != 0 && nums[stack.Peek()] > nums[i])
                    {
                        left = Math.Min(left, stack.Pop());
                    }
                    stack.Push(i);
                }

                stack.Clear();
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    while (stack.Count != 0 && nums[stack.Peek()] < nums[i])
                    {
                        right = Math.Max(right, stack.Pop());
                    }
                    stack.Push(i);
                }

                return (right - left > 0) ? right - left + 1 : 0;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Stack of size n is filled.
 * 		Space complexity : O(n). Stack size grows up to n
 */
