/*
 * Problem 49: Group Anagrams
 * Difficulty: Medium
 * 
 * Given an array of strings, group anagrams together.
 * 
 * Example:
 *      Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
 *      Output:
 *          [
 *            ["ate","eat","tea"],
 *            ["nat","tan"],
 *            ["bat"]
 *          ]
 * 
 * Note:
 *     All inputs will be in lowercase.
 *     The order of your output does not matter.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_49
    {
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                Dictionary<string, List<string>> dict =
                                        new Dictionary<string, List<string>>();

                for (int i = 0; i < strs.Length; i++)
                {
                    string sorted = Sort(strs[i]);
                    if (dict.ContainsKey(sorted))
                    {
                        dict[sorted].Add(strs[i]);
                    }
                    else
                    {
                        List<string> list = new List<string>();
                        list.Add(strs[i]);
                        dict[sorted] = list;
                    }
                }

                return dict.Values.ToList<IList<string>>(); ;
            }

            private string Sort(string str)
            {
                char[] c = str.ToCharArray();
                Array.Sort(c);
                return new string(c);
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity : O(NKlogK), where N is the length of strs, and K is the 
 * 					 maximum length of a string in strs. The outer loop has 
 * 					 complexity O(N) as we iterate through each string. Then, 
 * 					 we sort each string in O(Klog⁡K) time.
 * Space complexity: O(NK), the total information content stored in ans.
 */