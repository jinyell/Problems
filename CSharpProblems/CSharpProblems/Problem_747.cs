/*
 * Problem 747: Largest Number At Least Twice of Others
 * Difficulty: Easy
 * 
 * In a given integer array nums, there is always exactly one largest element.
 * 
 * Find whether the largest element in the array is at least twice as much 
 * as every other number in the array.
 * 
 * If it is, return the index of the largest element, otherwise return -1.
 * 
 * Example 1:
 *      Input: nums = [3, 6, 1, 0]
 *      Output: 1
 *      Explanation: 6 is the largest integer, and for every other number 
 * 		in the array x, 6 is more than twice as big as x.  The index of value 
 * 		6 is 1, so we return 1.
 * 
 * Example 2:
 *      Input: nums = [1, 2, 3, 4]
 *      Output: -1
 *      Explanation: 4 isn't at least as big as twice the value of 3, so we 
 * 					 return -1.
 * 
 * Note:
 *     nums will have a length in the range [1, 50].
 *     Every nums[i] will be an integer in the range [0, 99].
 */

namespace CSharpProblems
{
    public class Problem_747
    {
        public class Solution
        {
            public int DominantIndex(int[] nums)
            {
                if (nums == null || nums.Length == 0) { return -1; }
                if (nums.Length == 1) { return 0; }

                int largest = int.MinValue + 1;
                int secondLargest = int.MinValue;
                int index = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (largest < nums[i])
                    {
                        secondLargest = largest;
                        largest = nums[i];
                        index = i;
                    }
                    else if (nums[i] != largest && nums[i] > secondLargest)
                    {
                        secondLargest = nums[i];
                    }
                }
                return (secondLargest * 2 <= largest) ? index : -1;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
