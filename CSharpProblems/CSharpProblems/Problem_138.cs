/*
 * Problem 138: Copy List with Random Pointer
 * Difficulty: Medium
 * 
 * A linked list is given such that each node contains an additional random 
 * pointer which could point to any node in the list or null.
 * 
 * Return a deep copy of the list.
 * 
 * Example 1:
 *      Input: {"$id":"1","next":{"$id":"2","next":null,"random":{"$ref":"2"},
 * 				"val":2},"random":{"$ref":"2"},"val":1}
 *      Explanation: 
 *          - Node 1's value is 1, both of its next and random pointer 
 * 			  points to Node 2.
 *          - Node 2's value is 2, its next pointer points to null and 
 * 			  its random pointer points to itself.
 * 
 * Note: You must return the copy of the given head as a reference to the 
 * 		 cloned list.
 */

namespace CSharpProblems
{
    public class Problem_138
    {
        /*
        // Definition for a Node.
        public class Node {
            public int val;
            public Node next;
            public Node random;

            public Node(){}
            public Node(int _val,Node _next,Node _random) {
                val = _val;
                next = _next;
                random = _random;
        }
        */
        public class Solution
        {
            public RandomNode CopyRandomList(RandomNode head)
            {
                if (head == null) { return null; }

                RandomNode current = head;
                while (current != null)
                {
                    RandomNode next = current.next;
                    current.next = new RandomNode(current.val, next, null);
                    current = next;
                }

                current = head;
                while (current != null)
                {
                    if (current.random != null)
                    {
                        current.next.random = current.random.next;
                    }
                    current = current.next.next;
                }

                current = head;
                RandomNode copyHead = head.next;
                while (current != null)
                {
                    RandomNode after = current.next.next;
                    RandomNode copy = current.next;
                    current.next = after;
                    if (after != null)
                    {
                        copy.next = after.next;
                    }
                    current = after;
                }
                return copyHead;
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
