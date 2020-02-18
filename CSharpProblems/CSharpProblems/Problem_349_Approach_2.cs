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

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_349_Approach_2
    {
        public class Solution
        {
            public int[] Intersection(int[] nums1, int[] nums2)
            {
                HashSet<int> hs = new HashSet<int>();
                Array.Sort(nums1);
                Array.Sort(nums2);

                int count1 = 0;
                int count2 = 0;

                while (count1 < nums1.Length && count2 < nums2.Length)
                {
                    if (nums1[count1] < nums2[count2])
                    {
                        count1++;
                    }
                    else if (nums2[count2] < nums1[count1])
                    {
                        count2++;
                    }
                    else
                    {
                        hs.Add(nums1[count1]);
                        count1++;
                        count2++;
                    }
                }
                return hs.ToArray();
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
