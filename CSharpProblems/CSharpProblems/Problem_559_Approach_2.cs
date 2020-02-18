/*
 * Problem 559: Maximum Depth of N-ary Tree
 * Difficulty: Easy
 * 
 * Given a n-ary tree, find its maximum depth.
 * 
 * The maximum depth is the number of nodes along the longest path from the 
 * root node down to the farthest leaf node.
 * 
 * For example, given a 3-ary tree:
 * 
 *                      1
 *                    / | \
 *                   3  2  4
 *                  / \
 *                 5   6
 *  
 * We should return its max depth, which is 3.
 * 
 * Note:
 *     The depth of the tree is at most 1000.
 *     The total number of nodes is at most 5000.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_559_Approach_2
    {
        /*
        // Definition for a Node.
        public class Node {
            public int val;
            public IList<Node> children;

            public Node(){}
            public Node(int _val,IList<Node> _children) {
                val = _val;
                children = _children;
        }
        */
        public class Solution
        {
            public int MaxDepth(ChildrenNode root)
            {
                Queue<ChildrenNode> q1 = new Queue<ChildrenNode>();
                Queue<ChildrenNode> q2 = new Queue<ChildrenNode>();

                int depth = 0;
                if (root == null)
                {
                    return depth;
                }

                q1.Enqueue(root);
                while (q1.Count > 0)
                {
                    while (q1.Count > 0)
                    {
                        ChildrenNode curr = q1.Dequeue();
                        if (curr.children != null)
                        {
                            foreach (ChildrenNode child in curr.children)
                            {
                                q2.Enqueue(child);
                            }
                        }
                    }
                    depth++;
                    q1 = q2;
                    q2 = new Queue<ChildrenNode>();
                }

                return depth;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
