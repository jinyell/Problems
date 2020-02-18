/*
 * Problem 206: Reverse Linked List
 * Difficulty: Easy
 * 
 * Reverse a singly linked list.
 * 
 * Example:
 *      Input: 1->2->3->4->5->NULL
 *      Output: 5->4->3->2->1->NULL
 * 
 * Follow up: A linked list can be reversed either iteratively or recursively. 
 * Could you implement both?
 */

namespace CSharpProblems
{
    public class Problem_206
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
            public ListNode ReverseList(ListNode head)
            {
                if (head == null) { return head; }

                ListNode current = head;
                ListNode previous = null;
                ListNode next = null;

                while (current.next != null)
                {
                    next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                }

                current.next = previous;
                head = current;

                return head;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Assume that n is the list's length.
 * 		Space complexity : O(1)
 */
