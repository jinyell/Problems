﻿/*
 * Problem 922: Sort Array By Parity II
 * Difficulty: Easy
 * 
 * Given an array A of non-negative integers, half of the integers in A are 
 * odd, and half of the integers are even.
 * 
 * Sort the array so that whenever A[i] is odd, i is odd; and whenever 
 * A[i] is even, i is even.
 * 
 * You may return any answer array that satisfies this condition.
 * 
 * Example 1:
 *      Input: [4,2,5,7]
 *      Output: [4,5,2,7]
 *      Explanation: [4,7,2,5], [2,5,4,7], [2,7,4,5] would also have 
 * 					 been accepted.
 * 
 * Note:
 *     2 <= A.length <= 20000
 *     A.length % 2 == 0
 *     0 <= A[i] <= 1000
 */

namespace CSharpProblems
{
    public class Problem_922
    {
        public class Solution
        {
            public int[] SortArrayByParityII(int[] A)
            {
                int index = 0;
                int[] result = new int[A.Length];

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] % 2 == 0)
                    {
                        result[index] = A[i];
                        index += 2;
                    }
                }

                index = 1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] % 2 == 1)
                    {
                        result[index] = A[i];
                        index += 2;
                    }
                }

                return result;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the length of A
 * 		Space complexity : O(N)
 */
