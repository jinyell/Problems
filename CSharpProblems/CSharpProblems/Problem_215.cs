/*
 * Problem 215: Kth Largest Element in an Array
 * Difficulty: Medium
 * 
 * Find the kth largest element in an unsorted array. Note that it is the 
 * kth largest element in the sorted order, not the kth distinct element.
 * 
 * Example 1:
 *      Input: [3,2,1,5,6,4] and k = 2
 *      Output: 5
 * 
 * Example 2:
 *      Input: [3,2,3,1,2,4,5,5,6] and k = 4
 *      Output: 4
 * 
 * Note: You may assume k is always valid, 1 ≤ k ≤ array's length.
 */

using System;

namespace CSharpProblems
{
    public class Problem_215
    {
        public class Solution
        {
            public int FindKthLargest(int[] nums, int k)
            {
                k = nums.Length - k;
                int lo = 0;
                int hi = nums.Length - 1;

                while (lo < hi)
                {
                    int j = Partition(nums, lo, hi);

                    if (j < k)
                    {
                        lo = j + 1;
                    }
                    else if (j > k)
                    {
                        hi = j - 1;
                    }
                    else
                    {
                        break;
                    }
                }
                return nums[k];
            }

            private int Partition(int[] a, int lo, int hi)
            {

                int i = lo;
                int j = hi + 1;

                while (true)
                {
                    while (i < hi && Less(a[++i], a[lo])) ;
                    while (j > lo && Less(a[lo], a[--j])) ;
                    if (i >= j)
                    {
                        break;
                    }
                    Exch(a, i, j);
                }
                Exch(a, lo, j);
                return j;
            }

            private void Exch(int[] a, int i, int j)
            {
                int tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            private bool Less(int v, int w)
            {
                return v < w;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
