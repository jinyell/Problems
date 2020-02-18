/*
 * Problem 24: Swap Nodes in Pairs
 * Difficulty: Medium
 * 
 * Given a linked list, swap every two adjacent nodes and return its head.
 * 
 * You may not modify the values in the list's nodes, only nodes itself may be changed.
 * 
 * Example:
 *      Given 1->2->3->4, you should return the list as 2->1->4->3.
 */

namespace CSharpProblems
{
    public class Problem_24
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
            public ListNode SwapPairs(ListNode head)
            {
                if (head == null || head.next == null)
                {
                    return head;
                }

                ListNode nextNode = head.next;
                ListNode nextSwapHead = nextNode.next;
                nextNode.next = head;
                head.next = SwapPairs(nextSwapHead);

                return nextNode;
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
