/*
 * Problem 905: Sort Array By Parity
 * Difficulty: Easy
 * 
 * Given an array A of non-negative integers, return an array consisting 
 * of all the even elements of A, followed by all the odd elements of A.
 * 
 * You may return any answer array that satisfies this condition.
 *
 * Example 1:
 *      Input: [3,1,2,4]
 *      Output: [2,4,3,1]
 *      The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
 * 
 * Note:
 *     1 <= A.length <= 5000
 *     0 <= A[i] <= 5000
 */

namespace CSharpProblems
{
    public class Problem_905
    {
        public class Solution
        {
            public int[] SortArrayByParity(int[] A)
            {
                int startIndex = 0;
                int endIndex = A.Length - 1;

                while (startIndex < endIndex)
                {
                    if (A[startIndex] % 2 > A[endIndex] % 2)
                    {
                        int temp = A[startIndex];
                        A[startIndex] = A[endIndex];
                        A[endIndex] = temp;
                    }

                    if (A[startIndex] % 2 == 0) { startIndex++; }
                    if (A[endIndex] % 2 == 1) { endIndex--; }
                }

                return A;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the length of A
 * 		Space complexity : O(1) in additional space complexity
 */
