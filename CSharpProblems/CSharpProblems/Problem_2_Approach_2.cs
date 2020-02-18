/*
 * Problem 2: Add Two Numbers
 * Difficulty: Medium
 * 
 * You are given two non-empty linked lists representing two non-negative 
 * integers. The digits are stored in reverse order and each of their nodes 
 * contain a single digit. Add the two numbers and return it as a linked list.
 * 
 * You may assume the two numbers do not contain any leading zero, except 
 * the number 0 itself.
 * 
 * Example:
 *      Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
 *      Output: 7 -> 0 -> 8
 *      Explanation: 342 + 465 = 807.
 */

namespace CSharpProblems
{
    public class Problem_2_Approach_2
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) { val = x; }
         * }
         */
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummyHead = new ListNode(0);
                ListNode currL1 = l1;
                ListNode currL2 = l2;
                ListNode curr = dummyHead;
                int carry = 0;

                while (currL1 != null || currL2 != null)
                {
                    int valL1 = (currL1 == null) ? 0 : currL1.val;
                    int valL2 = (currL2 == null) ? 0 : currL2.val;
                    int sum = carry + valL1 + valL2;
                    carry = sum / 10;

                    int digit = sum % 10;
                    curr.next = new ListNode(digit);
                    curr = curr.next;

                    if (currL1 != null) { currL1 = currL1.next; }
                    if (currL2 != null) { currL2 = currL2.next; }
                }

                if (carry > 0)
                {
                    curr.next = new ListNode(carry);
                }

                return dummyHead.next;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity : O(max(m,n)). Assume that m and n represents the 
 * 					 length of l1 and l2.
 * Space complexity: O(max(m,n)). The length of the new list is at most 
 * 					 max(m,n) + 1
 */
