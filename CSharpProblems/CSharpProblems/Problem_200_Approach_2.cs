/*
 * Problem 200: Number of Islands
 * Difficulty: Medium
 * 
 * Given a 2d grid map of '1's (land) and '0's (water), count the number of 
 * islands. An island is surrounded by water and is formed by connecting 
 * adjacent lands horizontally or vertically. You may assume all four edges 
 * of the grid are all surrounded by water.
 * 
 * Example 1:
 *      Input:
 *          11110
 *          11010
 *          11000
 *          00000
 * 
 *      Output: 1
 * 
 * Example 2:
 *      Input:
 *          11000
 *          11000
 *          00100
 *          00011
 * 
 *      Output: 3
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_200_Approach_2
    {
        public class Solution
        {
            public int NumIslands(char[,] grid)
            {
                int numOfIslands = 0;

                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        if (grid[i, j] == '1')
                        {
                            BfsFill(grid, i, j);
                            numOfIslands++;
                        }
                    }
                }

                return numOfIslands;
            }

            private void BfsFill(char[,] grid, int x, int y)
            {
                grid[x, y] = '0';
                int xLength = grid.GetLength(0);
                int yLength = grid.GetLength(1);

                Queue<int[]> queue = new Queue<int[]>();
                queue.Enqueue(new int[2] { x, y });

                while (queue.Count != 0)
                {
                    int[] islandConnect = queue.Dequeue();

                    if (islandConnect[0] < xLength - 1 &&
                       grid[islandConnect[0] + 1, islandConnect[1]] == '1')
                    {
                        grid[islandConnect[0] + 1, islandConnect[1]] = '0';
                        queue.Enqueue(new int[2] { islandConnect[0] + 1,
                                                   islandConnect[1]});
                    }

                    if (islandConnect[0] > 0 &&
                       grid[islandConnect[0] - 1, islandConnect[1]] == '1')
                    {
                        grid[islandConnect[0] - 1, islandConnect[1]] = '0';
                        queue.Enqueue(new int[2] { islandConnect[0] - 1,
                                                   islandConnect[1]});
                    }

                    if (islandConnect[1] < yLength - 1 &&
                       grid[islandConnect[0], islandConnect[1] + 1] == '1')
                    {
                        grid[islandConnect[0], islandConnect[1] + 1] = '0';
                        queue.Enqueue(new int[2] { islandConnect[0],
                                                   islandConnect[1] + 1});
                    }

                    if (islandConnect[1] > 0 &&
                       grid[islandConnect[0], islandConnect[1] - 1] == '1')
                    {
                        grid[islandConnect[0], islandConnect[1] - 1] = '0';
                        queue.Enqueue(new int[2] { islandConnect[0],
                                                   islandConnect[1] - 1});
                    }
                }
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 

 */
