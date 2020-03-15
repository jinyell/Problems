/*
 * Problem 1351 Count Negative Numbers in a Sorted Matrix
 * Difficulty: Easy
 * 
 * Given a m * n matrix grid which is sorted in non-increasing order both row-wise and column-wise. 
 * 
 * Return the number of negative numbers in grid.
 * 
 * Example 1:
 *      Input: grid = [[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
 *      Output: 8
 *      Explanation: There are 8 negatives number in the matrix.
 * 
 * Example 2:
 *      Input: grid = [[3,2],[1,0]]
 *      Output: 0
 * 
 * Example 3:
 *      Input: grid = [[1,-1],[-1,-1]]
 *      Output: 3
 * 
 * Example 4:
 *      Input: grid = [[-1]]
 *      Output: 1
 *  
 * Constraints:
 *      m == grid.length
 *      n == grid[i].length
 *      1 <= m, n <= 100
 *      -100 <= grid[i][j] <= 100
 */

namespace CSharpProblems
{
    public class Problem_1351_Approach_2
    {
        public class Solution
        {
            public int CountNegatives(int[][] grid)
            {
                int res = 0;
                int m = grid.Length;
                int n = grid[0].Length;
                int i = 0;
                int j = n - 1;

                while (i < m && j >= 0)
                {
                    if (grid[i][j] < 0)
                    {
                        res += m - i;
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
                return res;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(M + N)
 * 		Space complexity :
 */
