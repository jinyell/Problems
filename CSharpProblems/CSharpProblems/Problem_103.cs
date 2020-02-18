/*
 * Problem 103: Binary Tree Zigzag Level Order Traversal
 * Difficulty: Medium
 * 
 * Given a binary tree, return the zigzag level order traversal of its 
 * nodes' values. (ie, from left to right, then right to left for the next 
 * level and alternate between).
 * 
 * For example:
 *  Given binary tree [3,9,20,null,null,15,7],
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 *  return its zigzag level order traversal as:
 * 
 *  [
 *   [3],
 *   [20,9],
 *   [15,7]
 *  ]
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_103
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int x) { val = x; }
         * }
         */
        public class Solution
        {
            public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
            {
                var list = new List<IList<int>>();
                if (root == null) return list;

                Queue<TreeNode> q = new Queue<TreeNode>();
                q.Enqueue(root);
                int level = 0;

                while (q.Count > 0)
                {
                    int count = q.Count;
                    List<int> l = new List<int>();

                    for (var i = 0; i < count; i++)
                    {
                        var node = q.Dequeue();
                        if (level % 2 == 0)
                        {
                            l.Add(node.val);
                        }
                        else
                        {
                            l.Insert(0, node.val);
                        }
                        if (node.left != null) q.Enqueue(node.left);
                        if (node.right != null) q.Enqueue(node.right);
                    }
                    level++;
                    list.Add(l);
                }

                return list;
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
