﻿/*
 * Problem 119: Pascal's Triangle II
 * Difficulty: Easy
 * 
 * Given a non-negative index k where k ≤ 33, return the kth index row of the 
 * Pascal's triangle.
 * 
 * Note that the row index starts from 0.
 * 
 * In Pascal's triangle, each number is the sum of the two numbers 
 * directly above it.
 * 
 * Example:
 * Input: 3
 * Output: [1,3,3,1]
 * 
 * Follow up:
 * Could you optimize your algorithm to use only O(k) extra space?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_119
    {
        public class Solution
        {
            public IList<int> GetRow(int rowIndex)
            {
                IList<int> row = new List<int>();

                for (int i = 0; i <= rowIndex; i++)
                {
                    for (int j = 0, last = 1; j <= i; j++)
                    {
                        if (j == i)
                        {
                            row.Add(1);
                        }
                        else if (j == 0)
                        {
                            continue;
                        }
                        else if (j < i)
                        {
                            int temp = row[j];
                            row[j] += last;
                            last = temp;
                        }
                    }
                }
                return row;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
