/*
 * Problem 102: Binary Tree Level Order Traversal
 * Difficulty: Medium
 * 
 * Given a binary tree, return the level order traversal of its nodes' 
 * values. (ie, from left to right, level by level).
 * 
 * For example:
 *      Given binary tree [3,9,20,null,null,15,7],
 * 
 *          3
 *         / \
 *        9  20
 *          /  \
 *         15   7
 * 
 *      return its level order traversal as:
 * 
 *       [
 *        [3],
 *        [9,20],
 *        [15,7]
 *       ]
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_102
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
            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                List<IList<int>> levelOrder = new List<IList<int>>();
                Traverse(root, levelOrder, 0);
                return levelOrder;
            }

            public void Traverse(TreeNode root, IList<IList<int>> levelOrder,
                                 int level)
            {
                if (root == null)
                {
                    return;
                }

                if (level >= levelOrder.Count)
                {
                    levelOrder.Add(new List<int>());
                }

                levelOrder[level].Add(root.val);
                Traverse(root.left, levelOrder, level + 1);
                Traverse(root.right, levelOrder, level + 1);
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
