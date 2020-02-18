/*
 * Problem 977: Squares of a Sorted Array
 * Difficulty: Easy
 * 
 * Given an array of integers A sorted in non-decreasing order, return an 
 * array of the squares of each number, also in sorted non-decreasing order.
 * 
 * Example 1:
 * Input: [-4,-1,0,3,10]
 * Output: [0,1,9,16,100]
 * 
 * Example 2:
 * Input: [-7,-3,2,3,11]
 * Output: [4,9,9,49,121]
 * 
 * Note:
 *     1 <= A.length <= 10000
 *     -10000 <= A[i] <= 10000
 *     A is sorted in non-decreasing order.
 */

using System;

namespace CSharpProblems
{
    public class Problem_977
    {
        public class Solution
        {
            public int[] SortedSquares(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = (A[i] * A[i]);
                }
                Array.Sort(A);
                return A;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N log N), where N is the length of A.
 * 		Space complexity : 
 */
