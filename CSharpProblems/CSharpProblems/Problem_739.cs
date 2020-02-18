/*
 * Problem 739: Daily Temperatures
 * Difficulty: Medium
 * 
 * Given a list of daily temperatures T, return a list such that, for each 
 * day in the input, tells you how many days you would have to wait until a 
 * warmer temperature. If there is no future day for which this is possible, 
 * put 0 instead.
 * 
 * For example, given the list of 
 * temperatures T = [73, 74, 75, 71, 69, 72, 76, 73], 
 * your output should be [1, 1, 4, 2, 1, 1, 0, 0].
 * 
 * Note: The length of temperatures will be in the range [1, 30000]. 
 * 		 Each temperature will be an integer in the range [30, 100]. 
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_739
    {
        public class Solution
        {
            public int[] DailyTemperatures(int[] T)
            {
                int[] ans = new int[T.Length];
                Stack<int> stack = new Stack<int>();

                for (int i = T.Length - 1; i >= 0; i--)
                {
                    while (stack.Count > 0 && T[i] >= T[stack.Peek()])
                    {
                        stack.Pop();
                    }
                    ans[i] = (stack.Count == 0) ? 0 : stack.Peek() - i;
                    stack.Push(i);
                }

                return ans;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the length of T and W is the number 
 * 						   of allowed values T[i]. Each index gets pushed and 
 * 						   popped at most once from the stack.
 * 		Space complexity : O(W). The size of the stack is bounded as it 
 * 						   represents strictly increasing temperatures.
 */
