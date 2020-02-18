/*
 * Problem 728: Self Dividing Numbers
 * Difficulty: Easy
 * 
 * A self-dividing number is a number that is divisible by every digit 
 * it contains.
 * 
 * For example, 128 is a self-dividing number because 128 % 1 == 0, 
 * 128 % 2 == 0, and 128 % 8 == 0.
 * 
 * Also, a self-dividing number is not allowed to contain the digit zero.
 * 
 * Given a lower and upper number bound, output a list of every possible 
 * self dividing number, including the bounds if possible.
 * 
 * Example 1:
 *      Input: left = 1, right = 22
 *      Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
 * 
 * Note: The boundaries of each input argument are 1 <= left <= right <= 10000.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_728
    {
        public class Solution
        {
            public IList<int> SelfDividingNumbers(int left, int right)
            {
                List<int> answer = new List<int>();

                for (int n = left; n <= right; n++)
                {
                    if (SelfDividing(n))
                    {
                        answer.Add(n);
                    }
                }

                return answer;
            }

            private bool SelfDividing(int n)
            {
                string number = n.ToString();

                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] == '0' || (n % (number[i] - '0') > 0))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(D), where D is the number of integers in the 
 * 						   range L,R and assuming log(R) is bounded
 * 		Space complexity : O(D), the length of the answer
 */
