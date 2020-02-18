/*
 * Problem 162: Find Peak Element
 * Difficulty: Medium
 * 
 * A peak element is an element that is greater than its neighbors.
 * 
 * Given an input array nums, where nums[i] ≠ nums[i+1], find a peak element 
 * and return its index.
 * 
 * The array may contain multiple peaks, in that case return the index to 
 * any one of the peaks is fine.
 * 
 * You may imagine that nums[-1] = nums[n] = -∞.
 * 
 * Example 1:
 *      Input: nums = [1,2,3,1]
 *      Output: 2
 *      Explanation: 3 is a peak element and your function should return 
 * 					 the index number 2.
 * 
 * Example 2:
 *      Input: nums = [1,2,1,3,5,6,4]
 *      Output: 1 or 5 
 *      Explanation: Your function can return either index number 1 where 
 * 		  the peak element is 2, or index number 5 where the peak element is 6.
 * 
 * Note: Your solution should be in logarithmic complexity.
 */

namespace CSharpProblems
{
    public class Problem_162
    {
        public class Solution
        {
            public int FindPeakElement(int[] nums)
            {
                int start = 0;
                int end = nums.Length - 1;

                while (start + 1 < end)
                {
                    int mid = start + (end - start) / 2;

                    if (nums[mid] > nums[mid - 1])
                    {
                        start = mid;
                    }
                    else
                    {
                        end = mid;
                    }
                }
                return nums[start] >= nums[end] ? start : end;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(log2(n)). We reduce the search space in half at 
 * 			every step. Thus, the total search space will be consumed in 
 * 			log2(n) steps. here, n refers to the size of nums array.
 * 		Space complexity : O(1). Constant extra space is used
 */
