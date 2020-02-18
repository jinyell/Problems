/*
 * Problem 83: Remove Duplicates from Sorted List
 * Difficulty: Easy
 * 
 * Given a sorted linked list, delete all duplicates such that each element 
 * appear only once.
 * 
 * Example 1:
 * Input: 1->1->2
 * Output: 1->2
 * 
 * Example 2:
 * Input: 1->1->2->3->3
 * Output: 1->2->3
 */

namespace CSharpProblems
{
    public class Problem_83
    {
        public class Solution
        {
            /* Definition for singly-linked list.
            public class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int x) { val = x; }
            }*/

            public ListNode DeleteDuplicates(ListNode head)
            {
                ListNode curr = head;
                while (curr != null && curr.next != null)
                {
                    if (curr.next.val == curr.val)
                    {
                        curr.next = curr.next.next;
                    }
                    else
                    {
                        curr = curr.next;
                    }
                }
                return head;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Because each node in the list is checked
 *						   exactly once to determine if it is a duplicate or
 *						   not, the total run time is O(n), where n is the 
 *						   number of nodes in the list.
 * 		Space complexity : O(1). No additional space is used
 */
