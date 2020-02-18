/*
 * Problem 937: Reorder Log Files
 * Difficulty: Easy
 * 
 * You have an array of logs.  Each log is a space delimited string of words.
 * 
 * For each log, the first word in each log is an alphanumeric identifier. 
 * Then either:
 *     Each word after the identifier will consist only of lowercase letters, 
 * 	or;
 *     Each word after the identifier will consist only of digits.
 * 
 * We will call these two varieties of logs letter-logs and digit-logs.  It is 
 * guaranteed that each log has at least one word after its identifier.
 * 
 * Reorder the logs so that all of the letter-logs come before any digit-log.  
 * The letter-logs are ordered lexicographically ignoring identifier, with the 
 * identifier used in case of ties.  The digit-logs should be put in their 
 * original order.
 * 
 * Return the final order of the logs.
 * 
 * Example 1:
 * Input: ["a1 9 2 3 1","g1 act car","zo4 4 7","ab1 off key dog","a8 act zoo"]
 * Output: ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]
 * 
 * Note:
 * 0 <= logs.length <= 100
 * 3 <= logs[i].length <= 100
 * logs[i] is guaranteed to have an identifier, & a word after the identifier.
 */

using System.Linq;
using System.Numerics;

namespace CSharpProblems
{
    public class Problem_937
    {
        public class Solution
        {
            public string[] ReorderLogFiles(string[] logs)
            {
                BigInteger i;

                var dl = logs.Where(l => BigInteger.TryParse(l.Split(' ')[1], out i));

                var ll = logs.Except(dl).OrderBy(l => l.Substring(l.IndexOf(' '))).ThenBy(t => t.Substring(0, t.IndexOf(' ')));

                return ll.Concat(dl).ToArray();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
