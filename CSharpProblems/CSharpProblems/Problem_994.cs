/*
 * Problem 994: Rotting Oranges
 * Difficulty: Easy
 * 
 * In a given grid, each cell can have one of three values:
 *     the value 0 representing an empty cell;
 *     the value 1 representing a fresh orange;
 *     the value 2 representing a rotten orange.
 * 
 * Every minute, any fresh orange that is adjacent (4-directionally) to a 
 * rotten orange becomes rotten.
 * 
 * Return the minimum number of minutes that must elapse until no cell has a 
 * fresh orange.  If this is impossible, return -1 instead.
 * 
 * Example 1:
 * Input: [[2,1,1],[1,1,0],[0,1,1]]
 * Output: 4
 * 
 * Example 2:
 * Input: [[2,1,1],[0,1,1],[1,0,1]]
 * Output: -1
 * Explanation:  The orange in the bottom left corner (row 2, column 0) is 
 * never rotten, because rotting only happens 4-directionally.
 * 
 * Example 3:
 * Input: [[0,2]]
 * Output: 0
 * Explanation:  Since there are already no fresh oranges at minute 0, the 
 * answer is just 0.
 * 
 * Note:
 *     1 <= grid.length <= 10
 *     1 <= grid[0].length <= 10
 *     grid[i][j] is only 0, 1, or 2.
 */

namespace CSharpProblems
{
    public class Problem_994
    {
        public class Solution
        {
            public int OrangesRotting(int[][] grid)
            {
                int noFresh = GetNoFresh(grid);

                if (noFresh == 0)
                    return 0;

                int minutes = 0;
                int prevFresh = noFresh;
                int currFresh = 0;
                while (true)
                {
                    for (int i = 0; i < grid.Length; i++)
                        for (int j = 0; j < grid[0].Length; j++)
                        {
                            if (grid[i][j] == 1 && IsAdjToRotten(grid, i, j))
                                grid[i][j] = 3;
                        }
                    for (int i = 0; i < grid.Length; i++)
                        for (int j = 0; j < grid[0].Length; j++)
                            if (grid[i][j] == 3)
                                grid[i][j] = 2;
                    minutes++;

                    currFresh = GetNoFresh(grid);
                    if (currFresh == 0)
                        return minutes;

                    if (currFresh == prevFresh)
                        return -1;

                    prevFresh = currFresh;
                }
            }

            private int GetNoFresh(int[][] grid)
            {
                int noFresh = 0;

                for (int i = 0; i < grid.Length; i++)
                    for (int j = 0; j < grid[0].Length; j++)
                        if (grid[i][j] == 1)
                            noFresh++;

                return noFresh;
            }

            private bool IsAdjToRotten(int[][] grid, int i, int j)
            {
                if (i - 1 >= 0 && grid[i - 1][j] == 2)
                    return true;
                if (i + 1 < grid.Length && grid[i + 1][j] == 2)
                    return true;
                if (j - 1 >= 0 && grid[i][j - 1] == 2)
                    return true;
                if (j + 1 < grid[0].Length && grid[i][j + 1] == 2)
                    return true;
                return false;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
