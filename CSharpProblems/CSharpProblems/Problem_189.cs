/*
 * Problem 189: Rotate Array
 * Difficulty: Easy
 * 
 * Given an array, rotate the array to the right by k steps, where 
 * k is non-negative.
 * 
 * Example 1:
 *      Input: [1,2,3,4,5,6,7] and k = 3
 *      Output: [5,6,7,1,2,3,4]
 *      Explanation:
 *          rotate 1 steps to the right: [7,1,2,3,4,5,6]
 *          rotate 2 steps to the right: [6,7,1,2,3,4,5]
 *          rotate 3 steps to the right: [5,6,7,1,2,3,4]
 * 
 * Example 2:
 *      Input: [-1,-100,3,99] and k = 2
 *      Output: [3,99,-1,-100]
 *      Explanation: 
 *          rotate 1 steps to the right: [99,-1,-100,3]
 *          rotate 2 steps to the right: [3,99,-1,-100]
 * 
 * Note:
 *     - Try to come up as many solutions as you can, there are at least 3 
 * 		 different ways to solve this problem.
 *     - Could you do it in-place with O(1) extra space?
 */

namespace CSharpProblems
{
    public class Problem_189
    {
        public class Solution
        {
            public void Rotate(int[] nums, int k)
            {
                if (nums.Length == 0 || k == 0)
                {
                    return;
                }

                k = k % nums.Length;
                int gcd = GCD(nums.Length, k);

                for (int cycleStart = 0; cycleStart < gcd; cycleStart++)
                {
                    int cycleDest = cycleStart;
                    int last = nums[cycleDest];
                    do
                    {
                        cycleDest = (cycleDest + k) % nums.Length;
                        int temp = nums[cycleDest];
                        nums[cycleDest] = last;
                        last = temp;
                    } while (cycleDest != cycleStart);
                }
            }

            private int GCD(int a, int b)
            {
                while (a != 0)
                {
                    int temp = a;
                    a = b % a;
                    b = temp;
                }
                return b;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). n elements are reversed a total of 3 times
 * 		Space complexity : O(1) No extra space is used
 */
