/*
 * Problem 347: Top K Frequent Elements
 * Difficulty: Medium
 *
 * Given a non-empty array of integers, return the k most frequent elements.
 * 
 * Example 1:
 *      Input: nums = [1,1,1,2,2,3], k = 2
 *      Output: [1,2]
 * 
 * Example 2:
 *      Input: nums = [1], k = 1
 * Output: [1]
 * 
 * Note:
 *     - You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
 *     - Your algorithm's time complexity must be better than O(n log n), 
 * 		 where n is the array's size.
 */

using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_347
    {
        public class Solution
        {
            public IList<int> TopKFrequent(int[] nums, int k)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))
                    {
                        dict[nums[i]]++;
                    }
                    else
                    {
                        dict.Add(nums[i], 1);
                    }
                }

                return dict.OrderByDescending(d => d.Value)
                           .Take(k)
                           .Select(d => d.Key)
                           .ToList();
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
