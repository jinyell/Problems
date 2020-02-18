/*
 * Problem 61: Rotate List
 * Difficulty: Medium
 * 
 * Given a linked list, rotate the list to the right by k places, where 
 * k is non-negative.
 * 
 * Example 1:
 *      Input: 1->2->3->4->5->NULL, k = 2
 *      Output: 4->5->1->2->3->NULL
 *      Explanation:
 *          rotate 1 steps to the right: 5->1->2->3->4->NULL
 *          rotate 2 steps to the right: 4->5->1->2->3->NULL
 * 
 * Example 2:
 *      Input: 0->1->2->NULL, k = 4
 *      Output: 2->0->1->NULL
 *      Explanation:
 *          rotate 1 steps to the right: 2->0->1->NULL
 *          rotate 2 steps to the right: 1->2->0->NULL
 *          rotate 3 steps to the right: 0->1->2->NULL
 *          rotate 4 steps to the right: 2->0->1->NULL
 */

namespace CSharpProblems
{
    public class Problem_61
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
            public ListNode RotateRight(ListNode head, int k)
            {
                if (head == null)
                {
                    return null;
                }

                if (head.next == null)
                {
                    return head;
                }

                ListNode oldTail = head;
                int total;

                for (total = 1; oldTail.next != null; total++)
                {
                    oldTail = oldTail.next;
                }

                oldTail.next = head;
                ListNode newTail = head;
                int tailPosition = (total - k % total - 1);

                for (int i = 0; i < tailPosition; i++)
                {
                    newTail = newTail.next;
                }

                ListNode newHead = newTail.next;
                newTail.next = null;

                return newHead;
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
