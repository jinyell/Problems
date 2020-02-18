/*
 * Problem 101: Symmetric Tree
 * Difficulty: Easy
 * 
 * Given a binary tree, check whether it is a mirror of itself (ie, symmetric 
 * around its center).
 * 
 * For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
 * 
 *     1
 *    / \
 *   2   2
 *  / \ / \
 * 3  4 4  3
 * 
 * But the following [1,2,2,null,3,null,3] is not:
 * 
 *     1
 *    / \
 *   2   2
 *    \   \
 *    3    3
 */

namespace CSharpProblems
{
    public class Problem_101
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
            public bool IsSymmetric(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }

                return Symmetrical(root.left, root.right);
            }

            public bool Symmetrical(TreeNode leftNode, TreeNode rightNode)
            {
                bool result = false;
                if (leftNode == null && rightNode == null)
                {
                    result = true;
                }

                if (leftNode != null && rightNode != null)
                {
                    result = (leftNode.val == rightNode.val) &&
                            Symmetrical(leftNode.left, rightNode.right) &&
                            Symmetrical(leftNode.right, rightNode.left);
                }
                return result;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Because we traverse the entire input tree once, 
 * 						   the total run time is O(n), where n is the total 
 * 						   number of nodes in the tree.
 * 		Space complexity : The number of recursive calls is bound by the height 
 * 						   of the tree. In the worst case, the tree is linear 
 * 						   and the height is in O(n). Therefore, space 
 * 						   complexity due to recursive calls on the stack is 
 * 						   O(n) in the worst case. 
 */
