/*
 * Problem 914: X of a Kind in a Deck of Cards
 * Difficulty: Easy
 * 
 * In a deck of cards, each card has an integer written on it.
 * 
 * Return true if and only if you can choose X >= 2 such that it is possible 
 * to split the entire deck into 1 or more groups of cards, where:
 *     Each group has exactly X cards.
 *     All the cards in each group have the same integer.
 * 
 * Example 1:
 *      Input: [1,2,3,4,4,3,2,1]
 *      Output: true
 *      Explanation: Possible partition [1,1],[2,2],[3,3],[4,4]
 * 
 * Example 2:
 *      Input: [1,1,1,2,2,2,3,3]
 *      Output: false
 *      Explanation: No possible partition.
 * 
 * Example 3:
 *      Input: [1]
 *      Output: false
 *      Explanation: No possible partition.
 * 
 * Example 4:
 *      Input: [1,1]
 *      Output: true
 *      Explanation: Possible partition [1,1]
 * 
 * Example 5:
 *      Input: [1,1,2,2,2,2]
 *      Output: true
 * Explanation: Possible partition [1,1],[2,2],[2,2]
 * 
 * Note:
 *     1 <= deck.length <= 10000
 *     0 <= deck[i] < 10000
 */
 
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_914
    {
        public class Solution
        {
            public bool HasGroupsSizeX(int[] deck)
            {
                int total = deck.Length;
                int[] count = new int[10000];

                for (int i = 0; i < total; i++)
                {
                    count[deck[i]]++;
                }

                List<int> values = new List<int>();

                for (int i = 0; i < 10000; i++)
                {
                    if (count[i] > 0)
                    {
                        values.Add(count[i]);
                    }
                }

                for (int i = 2; i <= total; i++)
                {
                    if (total % i == 0)
                    {
                        bool incorrect = false;
                        for (int v = 0; v < values.Count; v++)
                        {
                            if (values[v] % i != 0)
                            {
                                incorrect = true;
                                break;
                            }
                        }

                        if (incorrect == false)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N^2 log log N), where N is the number of cards. 
 * 						   Number of divisors of N is bounded by O(N log log N)
 * 		Space complexity : O(N)
 */
