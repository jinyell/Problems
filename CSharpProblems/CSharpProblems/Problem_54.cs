/*
 * Problem 54: Spiral Matrix
 * Difficulty: Medium
 * 
 * Given a matrix of m x n elements (m rows, n columns), return all elements 
 * of the matrix in spiral order.
 * 
 * Example 1:
 *      Input:
 *          [
 *           [ 1, 2, 3 ],
 *           [ 4, 5, 6 ],
 *           [ 7, 8, 9 ]
 *          ]
 *      Output: [1,2,3,6,9,8,7,4,5]
 * 
 * Example 2:
 *      Input:
 *          [
 *           [1, 2, 3, 4],
 *           [5, 6, 7, 8],
 *           [9,10,11,12]
 *          ]
 *      Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_54
    {
        public class Solution
        {
            public IList<int> SpiralOrder(int[,] matrix)
            {
                int top = 0;
                int left = 0;
                int bottom = matrix.GetLength(0) - 1;
                int right = matrix.GetLength(1) - 1;

                IList<int> list = new List<int>();
                int direction = 0;

                while (right >= left && bottom >= top)
                {
                    if (direction == 0)  // Top Side
                    {
                        for (int i = left; i <= right; i++)
                        {
                            list.Add(matrix[top, i]);
                        }
                        top++;
                    }
                    else if (direction == 1) // Right Side
                    {
                        for (int i = top; i <= bottom; i++)
                        {
                            list.Add(matrix[i, right]);
                        }
                        right--;
                    }
                    else if (direction == 2) // Bottom Side
                    {
                        for (int i = right; i >= left; i--)
                        {
                            list.Add(matrix[bottom, i]);
                        }
                        bottom--;
                    }
                    else if (direction == 3) // Left Side
                    {
                        for (int i = bottom; i >= top; i--)
                        {
                            list.Add(matrix[i, left]);
                        }
                        left++;
                    }

                    direction = (direction + 1) % 4;
                }

                return list;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity :
 * Space complexity:
 */
