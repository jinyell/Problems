/*
 * Problem 203: Remove Linked List Elements
 * Difficulty: Easy
 * 
 * Remove all elements from a linked list of integers that have value val.
 * 
 * Example:
 *      Input:  1->2->6->3->4->5->6, val = 6
 *      Output: 1->2->3->4->5
 */

namespace CSharpProblems
{
    public class Problem_203
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
            public ListNode RemoveElements(ListNode head, int val)
            {
                while (head != null && head.val == val)
                {
                    head = head.next;
                }

                if (head == null)
                {
                    return head;
                }

                ListNode current = head;
                while (current.next != null)
                {
                    if (current.next.val == val)
                    {
                        current.next = current.next.next;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
                return head;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
