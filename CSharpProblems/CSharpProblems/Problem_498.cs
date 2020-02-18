/*
 * Problem 498: Diagonal Traverse
 * Difficulty: Medium
 * 
 * Given a matrix of M x N elements (M rows, N columns), return all elements 
 * of the matrix in diagonal order as shown in the below image.
 * 
 * Example:
 *      Input:
 *          [
 *           [ 1, 2, 3 ],
 *           [ 4, 5, 6 ],
 *           [ 7, 8, 9 ]
 *          ]
 * 
 *      Output:  [1,2,4,7,5,3,6,8,9]
 * 
 *      Explanation:
 *      
 *          1   2   3
 *          
 *          4   5   6
 *          
 *          7   8   9
 * 
 * Note: The total # of elements of the given matrix will not exceed 10,000.
 */

namespace CSharpProblems
{
    public class Problem_498
    {
        public class Solution
        {
            public int[] FindDiagonalOrder(int[,] matrix)
            {
                int row = matrix.GetLength(0);
                int col = matrix.GetLength(1);
                int total = row * col;
                int[] order = new int[total];
                int index = 0;
                int xIndex = 0;
                int yIndex = 0;
                int move = 1;

                while (index < total)
                {
                    order[index++] = matrix[xIndex, yIndex];
                    xIndex -= move;
                    yIndex += move;

                    if (yIndex == col)
                    {
                        xIndex += 2;
                        yIndex--;
                        move = -move;
                    }
                    else if (xIndex == row)
                    {
                        xIndex--;
                        yIndex += 2;
                        move = -move;
                    }
                    else if (yIndex < 0)
                    {
                        yIndex++;
                        move = -move;
                    }
                    else if (xIndex < 0)
                    {
                        xIndex++;
                        move = -move;
                    }
                }

                return order;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
