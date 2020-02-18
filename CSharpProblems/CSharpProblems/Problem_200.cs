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

namespace CSharpProblems
{
    public class Problem_200
    {
        public class Solution
        {
            public int NumIslands(char[,] grid)
            {
                int numOfIslands = 0;
                int xLength = grid.GetLength(0);
                int yLength = grid.GetLength(1);
                bool[,] visited = new bool[xLength, yLength];

                for (int i = 0; i < xLength; i++)
                {
                    for (int j = 0; j < yLength; j++)
                    {
                        if (visited[i, j] || grid[i, j] == '0')
                        {
                            continue;
                        }

                        numOfIslands++;
                        DFS(grid, i, j, xLength, yLength, visited);
                    }
                }

                return numOfIslands;
            }

            private void DFS(char[,] grid, int x, int y, int xLength,
                             int yLength, bool[,] visited)
            {
                if (visited[x, y])
                {
                    return;
                }

                visited[x, y] = true;

                if (x > 0 && grid[x - 1, y] == '1')
                {
                    DFS(grid, x - 1, y, xLength, yLength, visited);
                }

                if (y > 0 && grid[x, y - 1] == '1')
                {
                    DFS(grid, x, y - 1, xLength, yLength, visited);
                }

                if (x < (xLength - 1) && grid[x + 1, y] == '1')
                {
                    DFS(grid, x + 1, y, xLength, yLength, visited);
                }

                if (y < (yLength - 1) && grid[x, y + 1] == '1')
                {
                    DFS(grid, x, y + 1, xLength, yLength, visited);
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
