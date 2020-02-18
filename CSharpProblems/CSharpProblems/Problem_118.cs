/*
 * Problem 118: Pascal's Triangle
 * Difficulty: Easy
 * 
 * Given a non-negative integer numRows, generate the first numRows of 
 * Pascal's triangle. In Pascal's triangle, each number is the sum of the two 
 * numbers directly above it.
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

/*
 * Complexity Analysis
 * 		Time complexity  : O(numRows^2) Although updating each value of 
 * 						   triangle happens in constant time, it is performed
 * 						   O(numRows^2) times. To see why, consider how many
 * 						   overall loop iterations there are. The outer loop
 * 						   obviously runs numRows times, but for each iteration
 * 						   of the outer loop, the inner loop runs rowNum times.
 * 						   Therefore, the overall number of triangle updates
 * 						   that occur is 1 + 2 + 3 + ... + numRows, which 
 * 						   according to Gauss' formula is: O(numRows^2)
 * 		Space complexity : O(numRows^2) Because we need to store each numbers
 * 						   that we update in triangle, the space requirement is
 * 						   the same as the time complexity.
 */
