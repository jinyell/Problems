/*
 * Problem 872: Leaf-Similar Trees
 * Difficulty: Easy
 * 
 * Consider all the leaves of a binary tree.  From left to right order, the 
 * values of those leaves form a leaf value sequence.
 * 
 *              3
 *            /   \
 *           5     1
 *         / |     | \
 *        6  2     9  8
 *          / \
 *         7   4
 * 
 * For example, in the given tree above, the leaf value sequence 
 * is (6, 7, 4, 9, 8).
 * 
 * Two binary trees are considered leaf-similar if their leaf value 
 * sequence is the same.
 * 
 * Return true if and only if the two given trees with head nodes root1 
 * and root2 are leaf-similar.
 * 
 * Note:
 *     Both of the given trees will have between 1 and 100 nodes.
 */

using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_872
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
            public bool LeafSimilar(TreeNode root1, TreeNode root2)
            {
                List<int> leaves1 = new List<int>();
                List<int> leaves2 = new List<int>();

                DepthFirstSearch(root1, leaves1);
                DepthFirstSearch(root2, leaves2);

                return leaves1.SequenceEqual(leaves2);
            }

            private void DepthFirstSearch(TreeNode node, List<int> leafValues)
            {
                if (node == null) { return; }

                if (node.left == null && node.right == null)
                {
                    leafValues.Add(node.val);
                }
                DepthFirstSearch(node.left, leafValues);
                DepthFirstSearch(node.right, leafValues);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(T1 + T2) where T1T2 are the lengths of 
 * 						   the given trees.
 * 		Space complexity : O(T1 + T2), the space used in storing the 
 * 						   leaf values.
 */
