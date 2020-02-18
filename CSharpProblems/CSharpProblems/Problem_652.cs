/*
 * Problem 652: Find Duplicate Subtrees
 * Difficulty: Medium
 * 
 * Given a binary tree, return all duplicate subtrees. For each kind of 
 * duplicate subtrees, you only need to return the root node of any 
 * one of them.
 * 
 * Two trees are duplicate if they have the same structure with same 
 * node values.
 * 
 * Example 1:
 * 
 *         1
 *        / \
 *       2   3
 *      /   / \
 *     4   2   4
 *        /
 *       4
 * 
 * The following are two duplicate subtrees:
 * 
 *       2
 *      /
 *     4
 * 
 * and
 * 
 *     4
 * 
 * Therefore, you need to return above trees' root in the form of a list.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_652
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
            public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
            {
                IList<TreeNode> result = new List<TreeNode>();
                PostOrder(root, new Dictionary<string, int>(), result);
                return result;
            }

            private string PostOrder(TreeNode current,
                        Dictionary<string, int> dict, IList<TreeNode> result)
            {
                if (current == null) { return "#"; }

                string path = current.val + "," +
                              PostOrder(current.left, dict, result) + "," +
                              PostOrder(current.right, dict, result);

                if (dict.ContainsKey(path))
                {
                    if (dict[path] == 1)
                    {
                        result.Add(current);
                        dict[path]++;
                    }
                }
                else
                {
                    dict.Add(path, 1);
                }

                return path;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
