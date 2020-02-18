/*
 * Problem 78: Subsets
 * Difficulty: Medium
 * 
 * Given a set of distinct integers, nums, return all possible 
 * subsets (the power set).
 * 
 * Note: The solution set must not contain duplicate subsets.
 * 
 * Example:
 *      Input: nums = [1,2,3]
 *      Output:
 *          [
 *           [3],
 *           [1],
 *           [2],
 *           [1,2,3],
 *           [1,3],
 *           [2,3],
 *           [1,2],
 *           []
 *          ]
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_78
    {
        public class Solution
        {
            public IList<IList<int>> Subsets(int[] nums)
            {
                IList<IList<int>> result = new List<IList<int>>();
                result.Add(new List<int>());

                for (int i = 0; i < nums.Length; i++)
                {
                    int size = result.Count;

                    for (int j = 0; j < size; j++)
                    {
                        IList<int> subset = new List<int>(result[j]);
                        subset.Add(nums[i]);
                        result.Add(subset);
                    }
                }
                return result;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity :
 * Space complexity:
 */
