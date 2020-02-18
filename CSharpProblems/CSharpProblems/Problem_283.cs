/*
 * Problem 283: Move Zeroes
 * Difficulty: Easy
 * 
 * Given an array nums, write a function to move all 0's to the end of it 
 * while maintaining the relative order of the non-zero elements.
 * 
 * Example:
 *      Input: [0,1,0,3,12]
 *      Output: [1,3,12,0,0]
 * 
 * Note:
 *     You must do this in-place without making a copy of the array.
 *     Minimize the total number of operations.
 */

namespace CSharpProblems
{
    public class Problem_283
    {
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        nums[count++] = nums[i];
                    }
                }

                for (int i = count; i < nums.Length; i++)
                {
                    nums[i] = 0;
                }
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : O(1). Only constant space is used.
 * 		Space complexity: O(n). However, the total number of operations are 
 * 						  still sub-optimal. The total operation (array writes) 
 * 						  that code does is n (Total number of elements).
 */
