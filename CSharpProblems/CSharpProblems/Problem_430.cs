﻿/*
 * Problem 430: Flatten a Multilevel Doubly Linked List
 * Difficulty: Medium
 *
 * You are given a doubly linked list which in addition to the next and 
 * previous pointers, it could have a child pointer, which may or may not 
 * point to a separate doubly linked list. These child lists may have one 
 * or more children of their own, and so on, to produce a multilevel data 
 * structure, as shown in the example below.
 * 
 * Flatten the list so that all the nodes appear in a single-level, doubly 
 * linked list. You are given the head of the first level of the list.
 * 
 * Example:
 * 
 * Input:
 *       1---2---3---4---5---6--NULL
 *               |
 *               7---8---9---10--NULL
 *                   |
 *                   11--12--NULL
 * 
 * Output:
 *      1-2-3-7-8-11-12-9-10-4-5-6-NULL
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_430
    {
        /*
        // Definition for a Node.
        public class Node {
            public int val;
            public Node prev;
            public Node next;
            public Node child;

            public Node(){}
            public Node(int _val,Node _prev,Node _next,Node _child) {
                val = _val;
                prev = _prev;
                next = _next;
                child = _child;
        }
        */
        public class Solution
        {
            public ChildNode Flatten(ChildNode head)
            {
                if (head == null) { return head; }

                ChildNode current = head;
                while (current != null)
                {
                    if (current.child == null)
                    {
                        current = current.next;
                    }
                    else
                    {
                        ChildNode currentChild = current.child;
                        while (currentChild.next != null)
                        {
                            currentChild = currentChild.next;
                        }
                        currentChild.next = current.next;

                        if (current.next != null)
                        {
                            current.next.prev = currentChild;
                        }

                        current.next = current.child;
                        current.child.prev = current;
                        current.child = null;
                    }
                }
                return head;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
