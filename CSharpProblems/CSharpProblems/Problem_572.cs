/*
 * Problem 572: Subtree of Another Tree
 * Difficulty: Easy
 * 
 * Given two non-empty binary trees s and t, check whether tree t has exactly 
 * the same structure and node values with a subtree of s. A subtree of s is a 
 * tree consists of a node in s and all of this node's descendants. The 
 * tree s could also be considered as a subtree of itself.
 * 
 * Example 1:
 *      Given tree s:
 * 
 *          3
 *         / \
 *        4   5
 *       / \
 *      1   2
 * 
 *      Given tree t:
 * 
 *          4 
 *         / \
 *        1   2
 * 
 *      Return true, because t has the same structure and node values with 
 * 		a subtree of s.
 * 
 * Example 2:
 *      Given tree s:
 * 
 *           3
 *          / \
 *         4   5
 *        / \
 *       1   2
 *          /
 *         0
 * 
 *      Given tree t:
 * 
 *         4
 *        / \
 *       1   2
 * 
 *      Return false. 
 */

namespace CSharpProblems
{
    public class Problem_572
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
            public bool IsSubtree(TreeNode s, TreeNode t)
            {
                if (s == null) { return false; }
                if (s.val == t.val)
                {
                    bool isSubTree = CheckSubTree(s, t);
                    if (isSubTree == true) { return true; }
                }

                return IsSubtree(s.left, t) || IsSubtree(s.right, t);
            }

            private bool CheckSubTree(TreeNode s, TreeNode t)
            {
                if (s == null && t == null) { return true; }
                if (s == null || t == null) { return false; }
                if (s.val != t.val) { return false; }
                return CheckSubTree(s.left, t.left) &&
                       CheckSubTree(s.right, t.right);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
