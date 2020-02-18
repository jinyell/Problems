/*
 * Problem 104: Maximum Depth of Binary Tree
 * Difficulty: Easy
 * 
 * Given a binary tree, find its maximum depth.
 * The maximum depth is the number of nodes along the longest path from the 
 * root node down to the farthest leaf node.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 * return its depth = 3.
 */
 
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_104_Approach_4
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
            public int MaxDepth(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                int count = 0;

                while (queue.Count != 0)
                {
                    int total = queue.Count;
                    while (total-- > 0)
                    {
                        TreeNode node = queue.Dequeue();

                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }

                    count++;
                }

                return count;
            }
        }
    }
}

/*
 * Using BFS
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
