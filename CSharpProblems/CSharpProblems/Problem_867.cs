/*
 * Problem 867: Transpose Matrix
 * Difficulty: Easy
 * 
 * Given a matrix A, return the transpose of A.
 * 
 * The transpose of a matrix is the matrix flipped over it's main diagonal, 
 * switching the row and column indices of the matrix.
 * 
 * Example 1:
 *      Input: [[1,2,3],[4,5,6],[7,8,9]]
 *      Output: [[1,4,7],[2,5,8],[3,6,9]]
 * 
 * Example 2:
 *      Input: [[1,2,3],[4,5,6]]
 *      Output: [[1,4],[2,5],[3,6]]
 * 
 * Note:
 *          1 <= A.length <= 1000
 *          1 <= A[0].length <= 1000
 */

namespace CSharpProblems
{
    public class Problem_867
    {
        public class Solution
        {
            public int[][] Transpose(int[][] A)
            {
                int[][] res = new int[A[0].Length][];
                for (int i = 0; i < A[0].Length; i++)
                {
                    res[i] = new int[A.Length];
                    for (int j = 0; j < A.Length; j++)
                    {
                        res[i][j] = A[j][i];
                    }
                }
                return res;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(R * C), where R and  C are the number of rows and 
 * 						   columns in the given matrix A.
 * 		Space complexity : O(R * C), the space used by the answer
 */
