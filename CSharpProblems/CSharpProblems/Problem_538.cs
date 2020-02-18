/*
 * Problem 538: Convert BST to Greater Tree
 * Difficulty: Easy
 * 
 * Given a Binary Search Tree (BST), convert it to a Greater Tree such that 
 * every key of the original BST is changed to the original key plus sum of 
 * all keys greater than the original key in BST.
 * 
 * Example:
 *      Input: The root of a Binary Search Tree like this:
 *               5
 *             /   \
 *            2     13
 * 
 *      Output: The root of a Greater Tree like this:
 *               18
 *             /    \
 *           20      13
 */

namespace CSharpProblems
{
    public class Problem_538
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
            int sum = 0;

            public TreeNode ConvertBST(TreeNode root)
            {
                if (root != null)
                {
                    ConvertBST(root.right);
                    sum += root.val;
                    root.val = sum;
                    ConvertBST(root.left);
                }

                return root;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n) A binary tree has no cycles by definition, 
 * 			so convertBST gets called on each node no more than once. Other 
 * 			than the recursive calls, convertBST does a constant amount of 
 * 			work, so a linear number of calls to convertBST will run in 
 * 			linear time.
 * 		Space complexity : O(n) Using the prior assertion that convertBST 
 * 			is called a linear number of times, we can also show that the 
 * 			entire algorithm has linear space complexity. Consider the worst 
 * 			case, a tree with only right (or only left) subtrees. The call 
 * 			stack will grow until the end of the longest path is reached, 
 * 			which in this case includes all n nodes.
 */
