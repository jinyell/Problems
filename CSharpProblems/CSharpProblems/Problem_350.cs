/*
 * Problem 350: Intersection of Two Arrays II
 * Difficulty: Easy
 *
 * Given two arrays, write a function to compute their intersection.
 * 
 * Example 1:
 *      Input: nums1 = [1,2,2,1], nums2 = [2,2]
 *      Output: [2,2]
 * 
 * Example 2:
 *      Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
 *      Output: [4,9]
 * 
 * Note:
 *     - Each element in the result should appear as many times as it 
 * 		 shows in both arrays.
 *     - The result can be in any order.
 * 
 * Follow up:
 *     - What if the given array is already sorted? How would you 
 * 		 optimize your algorithm?
 *     - What if nums1's size is small compared to nums2's size? 
 * 		 Which algorithm is better?
 *     - What if elements of nums2 are stored on disk, and the memory is 
 * 		 limited such that you can't load all elements into the memory at once?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_350
    {
        public class Solution
        {
            public int[] Intersect(int[] nums1, int[] nums2)
            {
                if (nums1 == null || nums2 == null)
                {
                    return null;
                }

                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (dict.ContainsKey(nums1[i]))
                    {
                        dict[nums1[i]]++;
                    }
                    else
                    {
                        dict[nums1[i]] = 1;
                    }
                }

                List<int> res = new List<int>();
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (dict.ContainsKey(nums2[i]))
                    {
                        if (dict[nums2[i]] > 0)
                        {
                            res.Add(nums2[i]);
                            dict[nums2[i]]--;
                        }
                    }
                }
                return res.ToArray();
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
