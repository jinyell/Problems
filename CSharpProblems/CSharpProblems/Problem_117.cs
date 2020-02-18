﻿/*
 * Problem 117: Populating Next Right Pointers in Each Node II
 * Difficulty: Medium
 * 
 * Given a binary tree
 * 
 * struct Node {
 *   int val;
 *   Node *left;
 *   Node *right;
 *   Node *next;
 * }
 * 
 * Populate each next pointer to point to its next right node. If there is 
 * no next right node, the next pointer should be set to NULL.
 * 
 * Initially, all next pointers are set to NULL.
 * 
 * Example:
 *          1                   1--> Null
 *         / \                 / \
 *        2   3               2-->3--> Null
 *       / \   \             / \   \
 *      4   5   7           4-->5-->7--> Null
 *      
 * Input: {"$id":"1","left":{"$id":"2","left":{"$id":"3","left":null,
 * 		   "next":null,"right":null,"val":4},"next":null,"right":{"$id":"4",
 * 		   "left":null,"next":null,"right":null,"val":5},"val":2},"next":null,
 * 		   "right":{"$id":"5","left":null,"next":null,"right":{"$id":"6",
 * 		   "left":null,"next":null,"right":null,"val":7},"val":3},"val":1}
 * Output: {"$id":"1","left":{"$id":"2","left":{"$id":"3","left":null,
 * 		    "next":{"$id":"4","left":null,"next":{"$id":"5","left":null,
 * 			"next":null,"right":null,"val":7},"right":null,"val":5},
 * 			"right":null,"val":4},"next":{"$id":"6","left":null,"next":null,
 * 			"right":{"$ref":"5"},"val":3},"right":{"$ref":"4"},"val":2},
 * 			"next":null,"right":{"$ref":"6"},"val":1}
 * Explanation: Given the above binary tree (Figure A), your function 
 * 				should populate each next pointer to point to its next right 
 * 				node, just like in Figure B.
 * 
 * Note:
 *     You may only use constant extra space.
 *     Recursive approach is fine, implicit stack space does not count 
 * 	   as extra space for this problem.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_117
    {
        /*
        // Definition for a Node.
        public class Node {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node(){}
            public Node(int _val,Node _left,Node _right,Node _next) {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
        }
        */
        public class Solution
        {
            public Node Connect(Node root)
            {
                if (root == null)
                {
                    return root;
                }

                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    int total = queue.Count;
                    for (int i = 0; i < total; i++)
                    {
                        Node node = queue.Dequeue();
                        Node nextNode = (i == total - 1) ? null : queue.Peek();
                        node.next = nextNode;

                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                }

                return root;
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
