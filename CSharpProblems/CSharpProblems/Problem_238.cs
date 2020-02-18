/*
 * Problem 238: Product of Array Except Self
 * Difficulty: Medium
 * 
 * Given an array nums of n integers where n > 1,  return an array output 
 * such that output[i] is equal to the product of all the elements of nums 
 * except nums[i].
 * 
 * Example:
 *      Input:  [1,2,3,4]
 *      Output: [24,12,8,6]
 * 
 * Note: Please solve it without division and in O(n).
 * 
 * Follow up: Could you solve it with constant space complexity? (The output 
 * 			  array does not count as extra space for the purpose of space 
 * 			  complexity analysis.)
 */

namespace CSharpProblems
{
    public class Problem_238
    {
        public class Solution
        {
            public int[] ProductExceptSelf(int[] nums)
            {
                int[] res = new int[nums.Length];
                res[0] = 1;
                int right = 1;

                for (int i = 1; i < nums.Length; i++)
                {
                    res[i] = res[i - 1] * nums[i - 1];
                }

                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    res[i] *= right;
                    right *= nums[i];
                }
                return res;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(N) where N represents the number of elements in 
 * 						  the input array. We use one interation to construct 
 * 						  the array L, one to update the array answer.
 * 		Space complexity: O(1) since we don't use any additional array for 
 * 						  our computations. The problem statement mentions 
 * 						  that using the answer array doesn't add to the space 
 * 						  complexity.
 */
