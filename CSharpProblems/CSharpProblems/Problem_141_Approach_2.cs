/*
 * Problem 141: Linked List Cycle
 * Difficulty: Easy
 * 
 * Given a linked list, determine if it has a cycle in it.
 * 
 * To represent a cycle in the given linked list, we use an integer pos 
 * which represents the position (0-indexed) in the linked list where tail 
 * connects to. If pos is -1, then there is no cycle in the linked list.
 * 
 * Example 1:
 *      3 --> 2 --> 0 --> 4 --
 *            ^              |
 *            |______________|
 *      Input: head = [3,2,0,-4], pos = 1
 *      Output: true
 *      Explanation: There is a cycle in the linked list, where tail 
 * 					 connects to the second node.
 * 
 * Example 2:
 *      1 --> 2 --
 *      ^        |
 *      |________|
 *      Input: head = [1,2], pos = 0
 *      Output: true
 *      Explanation: There is a cycle in the linked list, where tail 
 * 					 connects to the first node.
 * 
 * Example 3:
 *      1
 *      Input: head = [1], pos = -1
 *      Output: false
 *      Explanation: There is no cycle in the linked list.
 * 
 * Follow up: Can you solve it using O(1) (i.e. constant) memory?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_141_Approach_2
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
            public bool HasCycle(ListNode head)
            {

                HashSet<ListNode> nodesSeen = new HashSet<ListNode>();
                while (head != null)
                {
                    if (nodesSeen.Contains(head))
                    {
                        return true;
                    }
                    else
                    {
                        nodesSeen.Add(head);
                    }
                    head = head.next;
                }
                return false;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). We visit each of the n elements in the
 * 		                   list at most once. Adding a node to the hash
 * 		                   table costs only O(1) time.
 * 		Space complexity : O(n). The space depends on the number of
 * 		                   elements added to the hash table, which
 * 		                   contains at most n elements.
 */
