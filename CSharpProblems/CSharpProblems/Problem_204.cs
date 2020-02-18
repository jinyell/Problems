/*
 * Problem 204: Count Primes
 * Difficulty: Easy
 * 
 * Count the number of prime numbers less than a non-negative number, n.
 * 
 * Example:
 *      Input: 10
 *      Output: 4
 *      Explanation: There are 4 prime numbers less than 10, they 
 * 					 are 2, 3, 5, 7.
 */

namespace CSharpProblems
{
    public class Problem_204
    {
        public class Solution
        {
            public int CountPrimes(int n)
            {
                bool[] notPrime = new bool[n];
                int count = 0;

                for (int i = 2; i < n; i++)
                {
                    if (notPrime[i] == false)
                    {
                        count++;
                        for (int j = 2; i * j < n; j++)
                        {
                            notPrime[i * j] = true;
                        }
                    }
                }
                return count;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
