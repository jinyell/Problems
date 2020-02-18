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

namespace CSharpProblems
{
    public class Problem_141
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
                if (head == null)
                {
                    return false;
                }

                ListNode slow = head;
                ListNode fast = head;

                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                    if (slow == fast)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Let us denote n as the total number of nodes 
			in the linked list. To analyze its time complexity, we consider 
			the following two cases separately.
 *          - List has no cycle: The fast pointer reaches the end first and 
			  the run time depends on the list's length, which is O(n).
 *          - List has a cycle: We break down the movement of the slow pointer 
			  into two steps, the non-cyclic part and the cyclic part:
 *		      1. The slow pointer takes "non-cyclic length" steps to enter the 
			     cycle. At this point, the fast pointer has already reached the 
			     cycle. Number of iterations = non-cyclic length = N
 *            2. Both pointers are now in the cycle. Consider two runners 
				 running in a cycle - the fast runner moves 2 steps while the 
				 slow runner moves 1 steps at a time. Since the speed 
				 difference is 1, it takes 
				 (distance between the 2 runners) /(difference of speed) 
				 loops for the fast runner to catch up with the slow runner. 
				 As the distance is at most "cyclic length K" and the speed 
				 difference is 1, we conclude that 
				 Number of iterations=almost "cyclic length K".
 * 
 *               Therefore, the worst case time complexity is O(N+K), 
				 which is O(n).
 * 		Space complexity : O(1). We only use two nodes (slow and fast) so 
						   the space complexity is O(1).
 */
