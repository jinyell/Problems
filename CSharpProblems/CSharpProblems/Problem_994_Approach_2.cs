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

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_994_Approach_2
    {
        public class Solution
        {
            public int OrangesRotting(int[][] grid)
            {
                Queue<int[]> q = new Queue<int[]>();

                int oranges = 0;
                for (int i = 0; i < grid.Length; ++i)
                {
                    for (int j = 0; j < grid[0].Length; ++j)
                    {
                        if (grid[i][j] == 1)
                        {
                            oranges++;
                            int empty = 0;
                            if (i - 1 < 0 || grid[i - 1][j] == 0)
                            {
                                empty++;
                            }
                            if (i + 1 >= grid.Length || grid[i + 1][j] == 0)
                            {
                                empty++;
                            }
                            if (j - 1 < 0 || grid[i][j - 1] == 0)
                            {
                                empty++;
                            }
                            if (j + 1 >= grid[0].Length || grid[i][j + 1] == 0)
                            {
                                empty++;
                            }
                            if (empty == 4)
                            {
                                return -1;
                            }
                        }
                        else if (grid[i][j] == 2)
                        {
                            q.Enqueue(new int[] { i, j });
                        }
                    }
                }

                if (oranges == 0) return 0;
                if (q.Count == 0) return -1;

                int mins = 0;
                while (q.Count > 0)
                {
                    int qC = q.Count;
                    for (int idx = 0; idx < qC; ++idx)
                    {
                        int[] orange = q.Dequeue();
                        int i = orange[0];
                        int j = orange[1];

                        if (i - 1 >= 0 && grid[i - 1][j] == 1)
                        {
                            q.Enqueue(new int[] { i - 1, j });
                            grid[i - 1][j] = 2;
                            oranges--;
                        }
                        if (i + 1 < grid.Length && grid[i + 1][j] == 1)
                        {
                            q.Enqueue(new int[] { i + 1, j });
                            grid[i + 1][j] = 2;
                            oranges--;
                        }
                        if (j - 1 >= 0 && grid[i][j - 1] == 1)
                        {
                            q.Enqueue(new int[] { i, j - 1 });
                            grid[i][j - 1] = 2;
                            oranges--;
                        }
                        if (j + 1 < grid[0].Length && grid[i][j + 1] == 1)
                        {
                            q.Enqueue(new int[] { i, j + 1 });
                            grid[i][j + 1] = 2;
                            oranges--;
                        }
                    }

                    if (q.Count != 0) mins++;
                }

                return oranges == 0 ? mins : -1;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
