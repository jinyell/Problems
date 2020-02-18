/*
 * Problem 542: 01 Matrix
 * Difficulty: Medium
 * 
 * Given a matrix consists of 0 and 1, find the distance of the nearest 0 
 * for each cell.
 * 
 * The distance between two adjacent cells is 1.
 * 
 * Example 1:
 *      Input:
 *      [[0,0,0],
 *       [0,1,0],
 *       [0,0,0]]
 * 
 *  Output:
 *      [[0,0,0],
 *       [0,1,0],
 *       [0,0,0]]
 * 
 * Example 2:
 *      Input:
 *      [[0,0,0],
 *       [0,1,0],
 *       [1,1,1]]
 *      
 *      Output:
 *      [[0,0,0],
 *       [0,1,0],
 *       [1,2,1]]
 * 
 * Note:
 *     The number of elements of the given matrix will not exceed 10,000.
 *     There are at least one 0 in the given matrix.
 *     The cells are adjacent in only four directions: up, down, left & right.
 */

using System;

namespace CSharpProblems
{
    public class Problem_542
    {
        public class Solution
        {
            public int[,] UpdateMatrix(int[,] matrix)
            {
                int row = matrix.GetLength(0);
                int col = matrix.GetLength(1);

                if (row == 0)
                {
                    return new int[0, 0];
                }

                int[,] distanceMatrix = new int[row, col];
                int maxSize = row * col;

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            distanceMatrix[i, j] = 0;
                        }
                        else
                        {
                            int upPos = (i > 0) ? distanceMatrix[i - 1, j]
                                                : maxSize;
                            int leftPos = (j > 0) ? distanceMatrix[i, j - 1]
                                                  : maxSize;
                            distanceMatrix[i, j] = Math.Min(upPos, leftPos) + 1;
                        }
                    }
                }

                for (int i = row - 1; i >= 0; i--)
                {
                    for (int j = col - 1; j >= 0; j--)
                    {
                        if (matrix[i, j] == 0)
                        {
                            distanceMatrix[i, j] = 0;
                        }
                        else
                        {
                            int downPos = (i < row - 1) ? distanceMatrix[i + 1, j]
                                                      : maxSize;
                            int rightPos = (j < col - 1) ? distanceMatrix[i, j + 1]
                                                       : maxSize;
                            int checkMin = Math.Min(downPos, rightPos) + 1;
                            distanceMatrix[i, j] = Math.Min(checkMin,
                                                        distanceMatrix[i, j]);
                        }
                    }
                }

                return distanceMatrix;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(r * c). 2 passes of r * c each
 * 		Space complexity : O(r & c). No additional space required 
 * 						   than dist vector<vector<int>>.
 */
