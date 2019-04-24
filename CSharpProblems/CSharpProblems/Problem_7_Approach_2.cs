namespace CSharpProblems
{
    /*
     * Problem 7: Reverse Integer
     * Difficulty: Easy
     * 
     * Given a 32-bit signed integer, reverse digits of an integer.

     * Example 1:
     * Input: 123
     * Output: 321

     * Example 2:
     * Input: -123
     * Output: -321

     * Example 3:
     * Input: 120
     * Output: 21

     * Note:
     * Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
     * For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
    */

    public class Problem_7_Approach_2
    {
        public class Solution
        {
            public int Reverse(int x)
            {
                int reverse = 0;

                while (x != 0)
                {
                    int temp = (reverse * 10) + (x % 10);

                    if (temp / 10 != reverse)
                    {
                        return 0;
                    }
                    reverse = temp;
                    x /= 10;
                }
                return reverse;
            }
        }
    }
}