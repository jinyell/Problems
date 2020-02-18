/*
 * Problem 136: Single Number
 * Difficulty: Easy
 * 
 * Given a non-empty array of integers, every element appears twice except 
 * for one. Find that single one.
 * 
 * Note: Your algorithm should have a linear runtime complexity. Could you 
 * implement it without using extra memory?
 * 
 * Example 1:
 *      Input: [2,2,1]
 *      Output: 1
 * 
 * Example 2:
 *      Input: [4,1,2,1,2]
 *      Output: 4
 */

using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_136
    {
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {
                HashSet<int> hs = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (hs.Contains(nums[i]))
                    {
                        hs.Remove(nums[i]);
                    }
                    else
                    {
                        hs.Add(nums[i]);
                    }
                }
                return hs.ToArray()[0];
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity : O(n). Time complexity of for loop is O(n). Time 
 * 					 complexity of hash table operation pop is O(1)
 * Space complexity: O(n). The space required by hash_table is equal to 
 * 					 the number of elements in nums
 */
