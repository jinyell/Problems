/*
 * Problem 107: Binary Tree Level Order Traversal II
 * Difficulty: Easy
 * 
 * Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
 * 
 * For example:
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 * return its bottom-up level order traversal as:
 * 
 * [
 *   [15,7],
 *   [9,20],
 *   [3]
 * ]
 */
 
using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_107
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
            public IList<IList<int>> LevelOrderBottom(TreeNode root)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                List<IList<int>> levelList = new List<IList<int>>();

                if (root == null) { return levelList; }
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    int level = queue.Count;
                    List<int> subList = new List<int>();

                    for (int i = 0; i < level; i++)
                    {
                        if (queue.Peek().left != null)
                        {
                            queue.Enqueue(queue.Peek().left);
                        }

                        if (queue.Peek().right != null)
                        {
                            queue.Enqueue(queue.Peek().right);
                        }

                        subList.Add(queue.Dequeue().val);
                    }

                    levelList.Insert(0, subList);
                }

                return levelList;
            }
        }
    }
}
