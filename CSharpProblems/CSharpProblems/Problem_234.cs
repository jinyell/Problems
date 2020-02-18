/*
 * Problem 234: Palindrome Linked List
 * Difficulty: Easy
 * 
 * Given a singly linked list, determine if it is a palindrome.
 * 
 * Example 1:
 *      Input: 1->2
 *      Output: false
 * 
 * Example 2:
 *      Input: 1->2->2->1
 *      Output: true
 * 
 * Follow up: Could you do it in O(n) time and O(1) space?
 */

namespace CSharpProblems
{
    public class Problem_234
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
            public bool IsPalindrome(ListNode head)
            {
                if (head == null) { return true; }
                bool isPalindrome = true;
                Compare(head, head, ref isPalindrome);
                return isPalindrome;
            }

            private ListNode Compare(ListNode slow, ListNode fast,
                                     ref bool isPalindrome)
            {
                if (fast != null && fast.next != null)
                {
                    ListNode node = Compare(slow.next, fast.next.next,
                                            ref isPalindrome);

                    if (node == null || node.val != slow.val)
                    {
                        isPalindrome = false;
                        return null;
                    }

                    return node.next;
                }
                return (fast == null) ? slow : slow.next;
            }

        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity :
 * 		Space complexity:
 */
