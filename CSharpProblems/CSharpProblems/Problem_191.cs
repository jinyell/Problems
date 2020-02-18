/*
 * Problem 191: Number of 1 Bits
 * Difficulty: Easy
 * 
 * Write a function that takes an unsigned integer and return the number 
 * of '1' bits it has (also known as the Hamming weight).
 * 
 * Example 1:
 *      Input: 00000000000000000000000000001011
 *      Output: 3
 *      Explanation: The input binary string 00000000000000000000000000001011 
 * 					 has a total of three '1' bits.
 * 
 * Example 2:
 *      Input: 00000000000000000000000010000000
 *      Output: 1
 *      Explanation: The input binary string 00000000000000000000000010000000 
 * 					 has a total of one '1' bit.
 * 
 * Example 3:
 *      Input: 11111111111111111111111111111101
 *      Output: 31
 *      Explanation: The input binary string 11111111111111111111111111111101 
 * 					 has a total of thirty one '1' bits.
 * 
 * Note:
 *     - Note that in some languages such as Java, there is no unsigned integer 
 * 		 type. In this case, the input will be given as signed integer type 
 * 		 and should not affect your implementation, as the internal binary 
 * 		 representation of the integer is the same whether it is signed 
 * 		 or unsigned.
 *     - In Java, the compiler represents the signed integers using 2's 
 * 		 complement notation. Therefore, in Example 3 above the input 
 * 		 represents the signed integer -3.
 * 
 * Follow up: If this function is called many times, how would you optimize it?
 */

namespace CSharpProblems
{
    public class Problem_191
    {
        public class Solution
        {
            public int HammingWeight(uint n)
            {
                int count = 0;
                while (n != 0)
                {
                    count++;
                    n &= n - 1;
                }
                return count;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : The run time depends on the number of 1-bits in n. 
 * 						   In the worst case, all bits in n are 1-bits. In case 
 * 						   of a 32-bit integer, the run time is O(1).
 * 		Space complexity : The space complexity is O(1), since no additional 
 * 						   space is allocated.
 */
