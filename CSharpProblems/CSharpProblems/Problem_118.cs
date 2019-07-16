/*
 * Problem 118: Pascal's Triangle
 * Difficulty: Easy
 * 
 * Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
 * In Pascal's triangle, each number is the sum of the two numbers directly above it.
 * 
 * Example:
 * 
 * Input: 5
 * Output:
 * [
 *      [1],
 *     [1,1],
 *    [1,2,1],
 *   [1,3,3,1],
 *  [1,4,6,4,1]
 * ]
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_118
    {
        public class Solution
        {
            public IList<IList<int>> Generate(int numRows)
            {
                IList<IList<int>> pascal = new List<IList<int>>();

                if (numRows <= 0)
                {
                    return pascal;
                }

                IList<int> prevRow = new List<int>(numRows) { 1 };

                for (int i = 1; i <= numRows; i++)
                {
                    for (int j = prevRow.Count - 1; j > 0; j--)
                    {
                        prevRow[j] += prevRow[j - 1];
                    }

                    IList<int> row = new List<int>(prevRow);
                    pascal.Add(row);
                    prevRow.Add(0);
                }

                return pascal;
            }
        }
    }
}
