/*
 * Problem 219: Contains Duplicate II
 * Difficulty: Easy
 * 
 * Given an array of integers and an integer k, find out whether there are 
 * two distinct indices i and j in the array such that nums[i] = nums[j] 
 * and the absolute difference between i and j is at most k.
 * 
 * Example 1:
 *      Input: nums = [1,2,3,1], k = 3
 *      Output: true
 * 
 * Example 2:
 *      Input: nums = [1,0,1,1], k = 1
 *      Output: true
 * 
 * Example 3:
 *      Input: nums = [1,2,3,1,2,3], k = 2
 *      Output: false
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_219
    {
        public class Solution
        {
            public bool ContainsNearbyDuplicate(int[] nums, int k)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))
                    {
                        if (i - dict[nums[i]] <= k)
                        {
                            return true;
                        }
                    }
                    dict[nums[i]] = i;
                }
                return false;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : 
 * 		Space complexity: 
 */
