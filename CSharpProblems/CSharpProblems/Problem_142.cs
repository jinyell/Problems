/*
 * Problem 142: Linked List Cycle II
 * Difficulty: Medium
 * 
 * Given a linked list, return the node where the cycle begins. If there is 
 * no cycle, return null.
 * 
 * To represent a cycle in the given linked list, we use an integer pos 
 * which represents the position (0-indexed) in the linked list where tail 
 * connects to. If pos is -1, then there is no cycle in the linked list.
 * 
 * Note: Do not modify the linked list.
 * 
 * Example 1:
 *      Input: head = [3,2,0,-4], pos = 1
 *      Output: tail connects to node index 1
 *      Explanation: There is a cycle in the linked list, where tail connects 
 * 					 to the second node
 *      
 *      3 --> 2 --> 0 --> 4 --
 *            ^              |
 *            |______________|
 * 
 * Example 2:
 *      Input: head = [1,2], pos = 0
 *      Output: tail connects to node index 0
 *      Explanation: There is a cycle in the linked list, where tail connects 
 * 					 to the first node.
 *      
 *      1 --> 2 --
 *      ^        |
 *      |________|
 * 
 * Example 3:
 *      Input: head = [1], pos = -1
 *      Output: no cycle
 *      Explanation: There is no cycle in the linked list.
 *      
 *      1
 * 
 * Follow up: Can you solve it without using extra space?
 */

namespace CSharpProblems
{
    public class Problem_142
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) {
         *         val = x;
         *         next = null;
         *     }
         * }
         */
        public class Solution
        {
            public ListNode DetectCycle(ListNode head)
            {
                if (head == null || head.next == null)
                {
                    return null;
                }

                ListNode slow = head;
                ListNode fast = head;
                do
                {
                    slow = slow.next;
                    fast = fast.next.next;
                } while (fast != null && fast.next != null && fast != slow);

                if (fast == null || fast.next == null)
                {
                    return null;
                }

                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
