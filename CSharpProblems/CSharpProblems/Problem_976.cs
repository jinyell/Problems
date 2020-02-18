/*
 * Problem 976: Largest Perimeter Triangle
 * Difficulty: Easy
 * 
 * Given an array A of positive lengths, return the largest perimeter of a 
 * triangle with non-zero area, formed from 3 of these lengths.
 * 
 * If it is impossible to form any triangle of non-zero area, return 0.
 * 
 * Example 1:
 * Input: [2,1,2]
 * Output: 5
 * 
 * Example 2:
 * Input: [1,2,1]
 * Output: 0
 * 
 * Example 3:
 * Input: [3,2,3,4]
 * Output: 10
 * 
 * Example 4:
 * Input: [3,6,2,3]
 * Output: 8
 * 
 * Note:
 *     3 <= A.length <= 10000
 *     1 <= A[i] <= 10^6
 */

using System;

namespace CSharpProblems
{
    public class Problem_976
    {
        public class Solution
        {
            public int LargestPerimeter(int[] A)
            {
                Array.Sort(A);

                for (int i = A.Length - 3; i >= 0; i--)
                {
                    if ((A[i] + A[i + 1]) > A[i + 2])
                    {
                        return A[i] + A[i + 1] + A[i + 2];
                    }
                }
                return 0;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N log N), where N is the length of A.
 * 		Space complexity : O(1)
 */
