/*
 * Problem 378: Kth Smallest Element in a Sorted Matrix
 * Difficulty: Medium
 *
 * Given a n x n matrix where each of the rows and columns are sorted in 
 * ascending order, find the kth smallest element in the matrix.
 * 
 * Note that it is the kth smallest element in the sorted order, not the 
 * kth distinct element.
 * 
 * Example:
 * 
 *      matrix = [
 *          [ 1,  5,  9],
 *          [10, 11, 13],
 *          [12, 13, 15]
 *      ],
 *      k = 8,
 * 
 *      return 13.
 * 
 * Note: You may assume k is always valid, 1 ≤ k ≤ n2.
 */

namespace CSharpProblems
{
    public class Problem_378
    {
        public class Solution
        {
            public int KthSmallest(int[,] matrix, int k)
            {
                int lo = matrix[0, 0];
                int hi = matrix[(matrix.GetLength(0) - 1),
                                (matrix.GetLength(0) - 1)];

                while (lo < hi)
                {
                    int mid = lo + (hi - lo) / 2;
                    int count = 0;
                    int j = matrix.GetLength(0) - 1;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        while (j >= 0 && matrix[i, j] > mid)
                        {
                            j--;
                        }
                        count += (j + 1);
                    }

                    if (count < k)
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid;
                    }
                }
                return lo;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
