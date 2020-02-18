/*
 * Problem 590: N-ary Tree Postorder Traversal
 * Difficulty: Easy
 * 
 * Given an n-ary tree, return the postorder traversal of its nodes' values.
 * 
 * For example, given a 3-ary tree:
 * 
 *                  1
 *                / | \
 *               3  2  4
 *              / \
 *             5   6
 * 
 * Return its postorder traversal as: [5,6,3,2,4,1].
 * 
 * Note: Recursive solution is trivial, could you do it iteratively?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_590
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
            public IList<int> Postorder(ChildrenNode root)
            {
                IList<int> postorder = new List<int>();
                DetermineOrder(root, postorder);
                return postorder;
            }

            private void DetermineOrder(ChildrenNode root, IList<int> postorder)
            {
                if (root == null) { return; }

                if (root.children != null && root.children.Count > 0)
                {
                    for (int i = 0; i < root.children.Count; i++)
                    {
                        DetermineOrder(root.children[i], postorder);
                    }
                }

                postorder.Add(root.val);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
