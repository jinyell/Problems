/*
 * Problem 19: Remove Nth Node From End of List
 * Difficulty: Medium
 * 
 * Given a linked list, remove the n-th node from the end of list and 
 * return its head.
 * 
 * Example:
 *      Given linked list: 1->2->3->4->5, and n = 2.
 *      After removing the second node from the end, the linked list 
 * 		becomes 1->2->3->5.
 * 
 * Note: Given n will always be valid.
 * Follow up: Could you do this in one pass?
 */

namespace CSharpProblems
{
    public class Problem_19
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
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                ListNode slow = head;
                ListNode fast = head;
                int count = 0;

                while (count < n)
                {
                    fast = fast.next;
                    count++;
                }

                if (fast == null)
                {
                    return head.next;
                }

                fast = fast.next;

                while (fast != null)
                {
                    fast = fast.next;
                    slow = slow.next;
                }

                slow.next = slow.next.next;

                return head;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(L). The algorithm makes two traversal of the list, 
 * 								first to calculate list length L and second to 
 * 								find the (L - n) the node. There are 2L - n 
 * 								operations and time complexity is O(L).
 * 		Space complexity: O(1). We only used constant extra space
 */
