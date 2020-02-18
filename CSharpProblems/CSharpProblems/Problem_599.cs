/*
 * Problem 599: Longest Harmonious Subsequence
 * Difficulty: Easy
 * 
 * Suppose Andy and Doris want to choose a restaurant for dinner, and they 
 * both have a list of favorite restaurants represented by strings.
 * 
 * You need to help them find out their common interest with the least list 
 * index sum. If there is a choice tie between answers, output all of them 
 * with no order requirement. You could assume there always exists an answer.
 * 
 * Example 1:
 * 
 * Input:
 *      ["Shogun", "Tapioca Express", "Burger King", "KFC"]
 *      ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]
 * Output: ["Shogun"]
 * Explanation: The only restaurant they both like is "Shogun".
 * 
 * Example 2:
 * 
 * Input:
 *      ["Shogun", "Tapioca Express", "Burger King", "KFC"]
 *      ["KFC", "Shogun", "Burger King"]
 * Output: ["Shogun"]
 * Explanation: The restaurant they both like and have the least index sum 
 * 				is "Shogun" with index sum 1 (0+1).
 * 
 * Note:
 *     The length of both lists will be in the range of [1, 1000].
 *     The length of strings in both lists will be in the range of [1, 30].
 *     The index is starting from 0 to the list length minus 1.
 *     No duplicates in both lists.
 */

using System;
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_599
    {
        public class Solution
        {
            public string[] FindRestaurant(string[] list1, string[] list2)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                for (int i = 0; i < list1.Length; i++)
                {
                    dict[list1[i]] = i;
                }

                List<string> result = new List<string>();
                int maxIndex = int.MaxValue;

                for (int i = 0; i < list2.Length; i++)
                {
                    if (dict.ContainsKey(list2[i]))
                    {
                        int pos = dict[list2[i]];

                        if (pos + i < maxIndex)
                        {
                            result.Clear();
                            result.Add(list2[i]);
                            maxIndex = pos + i;
                        }
                        else if (pos + i == maxIndex)
                        {
                            result.Add(list2[i]);
                        }
                    }
                }
                return result.ToArray();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(l1 + l2). Every item of list2 is checked in a map 
 * 						   of list1. l1 and l2 are the lengths of list1 and 
 * 						   list2 respectively.
 * 		Space complexity : O(l1 * x). Hashmap size grows up to l1 * x, where 
 * 						   x refers to average string length.
 */
