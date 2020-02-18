/*
 * Problem 412: Fizz Buzz
 * Difficulty: Easy
 *
 * Write a program that outputs the string representation of numbers from 1 to n.
 * 
 * But for multiples of three it should output “Fizz” instead of the number 
 * and for the multiples of five output “Buzz”. For numbers which are multiples 
 * of both three and five output “FizzBuzz”.
 * 
 * Example:
 *      n = 15,
 * 
 *      Return:
 *      [
 *          "1",
 *          "2",
 *          "Fizz",
 *          "4",
 *          "Buzz",
 *          "Fizz",
 *          "7",
 *          "8",
 *          "Fizz",
 *          "Buzz",
 *          "11",
 *          "Fizz",
 *          "13",
 *          "14",
 *          "FizzBuzz"
 *      ]
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_412
    {
        public class Solution
        {
            public IList<string> FizzBuzz(int n)
            {
                IList<string> str = new List<string>();

                for (int i = 1; i <= n; i++)
                {
                    str.Add(((i % 15) == 0) ? "FizzBuzz" : ((i % 3) == 0) ?
                            "Fizz" : ((i % 5) == 0) ? "Buzz" : i.ToString());
                }
                return str;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
