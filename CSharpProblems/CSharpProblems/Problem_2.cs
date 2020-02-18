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
    public class Problem_2
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
                ListNode head = null;
                ListNode node = null;
                int carry = 0;

                while (l1 != null || l2 != null)
                {
                    int valL1 = (l1 == null) ? 0 : l1.val;
                    int valL2 = (l2 == null) ? 0 : l2.val;
                    int sum = carry + valL1 + valL2;
                    carry = sum / 10;

                    int digit = sum % 10;
                    if (head == null)
                    {
                        head = new ListNode(digit);
                        node = head;
                    }
                    else
                    {
                        node.next = new ListNode(digit);
                        node = node.next;
                    }

                    if (l1 != null) { l1 = l1.next; }
                    if (l2 != null) { l2 = l2.next; }
                }

                if (carry > 0)
                {
                    node.next = new ListNode(carry);
                }

                return head;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity : 
 * Space complexity: 
 */
