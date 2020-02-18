/*
 * Problem 21: Merge Two Sorted Lists
 * Difficulty: Easy
 * 
 * Merge two sorted linked lists and return it as a new list. The new list 
 * should be made by splicing together the nodes of the first two lists.
 * 
 * Example:
 * Input: 1->2->4, 1->3->4
 * Output: 1->1->2->3->4->4
 */

namespace CSharpProblems
{
    public class Problem_21_Approach_2
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
            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                if (l1 == null)
                {
                    return l2;
                }

                if (l2 == null)
                {
                    return l1;
                }

                ListNode merged = new ListNode(0);
                ListNode curr = merged;

                while (l1 != null || l2 != null)
                {
                    if (l1 == null)
                    {
                        curr.next = l2;
                        l2 = l2.next;
                    }
                    else if (l2 == null)
                    {
                        curr.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        if (l1.val > l2.val)
                        {
                            curr.next = l2;
                            l2 = l2.next;
                        }
                        else
                        {
                            curr.next = l1;
                            l1 = l1.next;
                        }
                    }

                    curr = curr.next;
                }

                return merged.next;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
