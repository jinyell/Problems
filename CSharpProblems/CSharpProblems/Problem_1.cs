using System.Collections.Generic;

namespace CSharpProblems
{
    /*
     * Problem 1: Two Sum
     * Difficulty: Easy
     * 
     * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.

     * Example:
     * Given nums = [2, 7, 11, 15], target = 9,
     * Because nums[0] + nums[1] = 2 + 7 = 9,
     * return [0, 1].
     */

    public class Problem_1
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int check = target - nums[i];
                    if (dict.ContainsKey(check))
                    {
                        return new int[2] { dict[check], i };
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
                return null;
            }
        }
    }
}
