/*
 * Problem 349: Intersection of Two Arrays
 * Difficulty: Easy
 *
 * Given two arrays, write a function to compute their intersection.
 * 
 * Example 1:
 *      Input: nums1 = [1,2,2,1], nums2 = [2,2]
 *      Output: [2]
 * 
 * Example 2:
 *      Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
 *      Output: [9,4]
 * 
 * Note:
 *     Each element in the result must be unique.
 *     The result can be in any order.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_349
    {
        public class Solution
        {
            public int[] Intersection(int[] nums1, int[] nums2)
            {
                if (nums1 == null || nums2 == null)
                {
                    return new int[0];
                }

                HashSet<int> hs = new HashSet<int>();

                for (int i = 0; i < nums1.Length; i++)
                {
                    hs.Add(nums1[i]);
                }

                List<int> res = new List<int>();
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (hs.Contains(nums2[i]))
                    {
                        res.Add(nums2[i]);
                        hs.Remove(nums2[i]);
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
