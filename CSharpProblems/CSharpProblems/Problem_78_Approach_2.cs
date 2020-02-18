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
    public class Problem_78_Approach_2
    {
        public class Solution
        {
            public IList<IList<int>> Subsets(int[] nums)
            {
                var res = new List<IList<int>>();
                Permute(nums, 0, res, new List<int>());
                return res;
            }

            private void Permute(int[] nums, int start, IList<IList<int>> res,
                                 IList<int> list)
            {
                res.Add(new List<int>(list));

                for (int i = start; i < nums.Length; i++)
                {
                    list.Add(nums[i]);
                    Permute(nums, i + 1, res, list);
                    list.RemoveAt(list.Count - 1);
                }
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
