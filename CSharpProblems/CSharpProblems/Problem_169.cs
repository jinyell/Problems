/*
 * Problem 169: Majority Element
 * Difficulty: Easy
 * 
 * Given an array of size n, find the majority element. The majority element 
 * is the element that appears more than ⌊ n/2 ⌋ times.
 * 
 * You may assume that the array is non-empty and the majority element 
 * always exist in the array.
 * 
 * Example 1:
 *      Input: [3,2,3]
 *      Output: 3
 * 
 * Example 2:
 *      Input: [2,2,1,1,1,2,2]
 *      Output: 2
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_169
    {
        public class Solution
        {
            public int MajorityElement(int[] nums)
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

                int highest = 0;
                int answer = 0;

                foreach (var item in dict)
                {
                    if (item.Value > highest)
                    {
                        highest = item.Value;
                        answer = item.Key;
                    }
                }
                return answer;

            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
