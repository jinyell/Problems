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
    public class Problem_102_Approach_2
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
                IList<IList<int>> levelOrder = new List<IList<int>>();

                if (root == null)
                {
                    return levelOrder;
                }

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    int currentLevelSize = queue.Count;
                    List<int> sublist = new List<int>();
                    int index = 0;
                    while (index < currentLevelSize)
                    {
                        TreeNode node = queue.Peek();
                        queue.Dequeue();
                        sublist.Add(node.val);

                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }

                        index++;
                    }

                    levelOrder.Add(sublist);
                }

                return levelOrder;
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
