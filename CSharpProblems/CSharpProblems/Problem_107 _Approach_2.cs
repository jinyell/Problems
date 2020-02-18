/*
 * Problem 107: Binary Tree Level Order Traversal II
 * Difficulty: Easy
 * 
 * Given a binary tree, return the bottom-up level order traversal of its 
 * nodes' values. (ie, from left to right, level by level from leaf to root).
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
    public class Problem_107_Approach_2
    {
        /*
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
                IList<IList<int>> list = new List<IList<int>>();
                Level(list, root, 0);
                return list.Reverse().ToList();
            }

            private void Level(IList<IList<int>> list, TreeNode root, int level)
            {
                if (root == null)
                {
                    return;
                }

                if (level >= list.Count)
                {
                    list.Add(new List<int>());
                }

                list[level].Add(root.val);
                Level(list, root.left, level + 1);
                Level(list, root.right, level + 1);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
