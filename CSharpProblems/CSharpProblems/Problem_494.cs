/*
 * Problem 494: Target Sum
 * Difficulty: Medium
 * 
 * You are given a list of non-negative integers, a1, a2, ..., an, and a 
 * target, S. Now you have 2 symbols + and -. For each integer, you should 
 * choose one from + and - as its new symbol.
 * 
 * Find out how many ways to assign symbols to make sum of integers equal 
 * to target S.
 * 
 * Example 1:
 *      Input: nums is [1, 1, 1, 1, 1], S is 3. 
 *      Output: 5
 *      Explanation: 
 *          -1+1+1+1+1 = 3
 *          +1-1+1+1+1 = 3
 *          +1+1-1+1+1 = 3
 *          +1+1+1-1+1 = 3
 *          +1+1+1+1-1 = 3
 * 
 *      There are 5 ways to assign symbols to make the sum of nums be target 3.
 * 
 *      Note:
 *          The length of the given array is positive and will not exceed 20.
 *          The sum of elements in the given array will not exceed 1000.
 *          Your output answer is guaranteed to be fitted in a 32-bit integer.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_494
    {
        public class Solution
        {
            public int FindTargetSumWays(int[] nums, int S)
            {
                Dictionary<int, int>[] dicts =
                                        new Dictionary<int, int>[nums.Length];

                for (int i = 0; i < nums.Length; i++)
                {
                    dicts[i] = new Dictionary<int, int>();
                }

                return Count(nums, 0, S, dicts);
            }

            private int Count(int[] nums, int index, int target,
                                    Dictionary<int, int>[] dict)
            {
                if (index == nums.Length)
                {
                    return (target == 0) ? 1 : 0;
                }

                if (dict[index].ContainsKey(target))
                {
                    return dict[index][target];
                }

                int count = Count(nums, index + 1, target - nums[index], dict) +
                            Count(nums, index + 1, target + nums[index], dict);

                dict[index][target] = count;
                return count;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
