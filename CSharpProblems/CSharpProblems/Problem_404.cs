/*
 * Problem 404: Sum of Left Leaves
 * Difficulty: Easy
 *
 * Find the sum of all left leaves in a given binary tree.
 * 
 * Example:
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 * There are two left leaves in the binary tree, with values 9 and 15 
 * respectively. Return 24.
 */

namespace CSharpProblems
{
    public class Problem_404
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
            public int SumOfLeftLeaves(TreeNode root)
            {
                int sum = 0;
                SumLeft(root, false, ref sum);
                return sum;
            }

            private void SumLeft(TreeNode root, bool left, ref int sum)
            {
                if (root == null) { return; }
                if (left == true && root.left == null && root.right == null)
                {
                    sum += root.val;
                }
                SumLeft(root.left, true, ref sum);
                SumLeft(root.right, false, ref sum);
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
