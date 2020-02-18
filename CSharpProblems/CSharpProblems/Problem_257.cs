/*
 * Problem 257: Binary Tree Paths
 * Difficulty: Easy
 * 
 * Given a binary tree, return all root-to-leaf paths.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 *      Input:
 * 
 *             1
 *           /   \
 *          2     3
 *           \
 *            5
 * 
 * Output: ["1->2->5", "1->3"]
 * 
 * Explanation: All root-to-leaf paths are: 1->2->5, 1->3
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_257
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
            public IList<string> BinaryTreePaths(TreeNode root)
            {
                IList<string> list = new List<string>();

                if (root == null)
                {
                    return list;
                }

                Helper(root, string.Empty, list);

                return list;
            }

            private void Helper(TreeNode root, string current,
                                IList<string> list)
            {
                if (root == null)
                {
                    return;
                }

                if (current == string.Empty)
                {
                    current = root.val.ToString();
                }
                else
                {
                    current += $"->{root.val}";
                }

                if (root.left == null && root.right == null)
                {
                    list.Add(current);
                }
                else
                {
                    Helper(root.left, current, list);
                    Helper(root.right, current, list);
                }
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity :
 * 		Space complexity:
 */
