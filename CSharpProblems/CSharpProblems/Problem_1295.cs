/*
 * Problem 1295: Find Numbers with Even Number of Digits
 * Difficulty: Easy
 * 
 * Given an array nums of integers, return how many of them contain an even number of digits.
 *  
 * Example 1:
 *      Input: nums = [12,345,2,6,7896]
 *      Output: 2
 *      Explanation: 
 *          12 contains 2 digits (even number of digits). 
 *          345 contains 3 digits (odd number of digits). 
 *          2 contains 1 digit (odd number of digits). 
 *          6 contains 1 digit (odd number of digits). 
 *          7896 contains 4 digits (even number of digits). 
 *          Therefore only 12 and 7896 contain an even number of digits.
 * 
 * Example 2:
 *      Input: nums = [555,901,482,1771]
 *      Output: 1 
 *      Explanation: 
 *          Only 1771 contains an even number of digits.
 *  
 * Constraints:
 *      1 <= nums.length <= 500
 *      1 <= nums[i] <= 10^5
 */

using System;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_1295
    {
        public class Solution
        {
            public int FindNumbers(int[] nums) => nums.Count(n => ((int)Math.Log(n, 10)) % 2 == 1);
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */

/*
 * Understanding how log works
 *
    public class Example
    {
       public static void Main()
       {
          double[] numbers = {-1, 0, .105, .5, .798, 1, 4, 6.9, 10, 50, 
                              100, 500, 1000, Double.MaxValue};
      
          foreach (double number in numbers)
             Console.WriteLine("The base 10 log of {0} is {1}.", 
                               number, Math.Log10(number));
       }
    }
    // The example dislays the following output:
    //       The base 10 log of -1 is NaN.
    //       The base 10 log of 0 is -Infinity.
    //       The base 10 log of 0.105 is -0.978810700930062.
    //       The base 10 log of 0.5 is -0.301029995663981.
    //       The base 10 log of 0.798 is -0.0979971086492706.
    //       The base 10 log of 1 is 0.
    //       The base 10 log of 4 is 0.602059991327962.
    //       The base 10 log of 6.9 is 0.838849090737255.
    //       The base 10 log of 10 is 1.
    //       The base 10 log of 50 is 1.69897000433602.
    //       The base 10 log of 100 is 2.
    //       The base 10 log of 500 is 2.69897000433602.
    //       The base 10 log of 1000 is 3.
    //       The base 10 log of 1.79769313486232E+308 is 308.254715559917.
 */
