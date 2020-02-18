/*
 * Problem 852: Peak Index in a Mountain Array
 * Difficulty: Easy
 * 
 * Let's call an array A a mountain if the following properties hold:
 * 
 *     A.length >= 3
 *     There exists some 0 < i < A.length - 1 such that A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1]
 * 
 * Given an array that is definitely a mountain, return any i such that A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1].
 * 
 * Example 1:
 *      Input: [0,1,0]
 *      Output: 1
 * 
 * Example 2:
 *      Input: [0,2,1,0]
 *      Output: 1
 * 
 * Note:
 *     3 <= A.length <= 10000
 *     0 <= A[i] <= 10^6
 *     A is a mountain, as defined above.
 */

using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_852
    {
        public class Solution
        {
            public int PeakIndexInMountainArray(int[] A)
            {
                int index = 0;
                while (A[index] < A[index + 1])
                {
                    index++;
                }
                return index;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the length of A
 * 		Space complexity : O(1)
 */
