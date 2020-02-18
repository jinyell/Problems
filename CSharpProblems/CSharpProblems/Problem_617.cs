/*
 * Problem 617: Merge Two Binary Trees
 * Difficulty: Easy
 * 
 * Given two binary trees and imagine that when you put one of them to cover 
 * the other, some nodes of the two trees are overlapped while the others 
 * are not.
 * 
 * You need to merge them into a new binary tree. The merge rule is that if 
 * two nodes overlap, then sum node values up as the new value of the merged 
 * node. Otherwise, the NOT null node will be used as the node of new tree.
 * 
 * Example 1:
 * 
 * Input: 
 * 	Tree 1                     Tree 2                  
 *           1                         2                             
 *          / \                       / \                            
 *         3   2                     1   3                        
 *        /                           \   \                      
 *       5                             4   7                  
 * Output: 
 * Merged tree:
 * 	     3
 * 	    / \
 * 	   4   5
 * 	  / \   \ 
 * 	 5   4   7
 * 
 * Note: The merging process must start from the root nodes of both trees.
 */

namespace CSharpProblems
{
    public class Problem_617
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
            public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
            {
                if (t1 == null) { return t2; }
                if (t2 == null) { return t1; }

                t1.val += t2.val;
                t1.left = MergeTrees(t1.left, t2.left);
                t1.right = MergeTrees(t1.right, t2.right);

                return t1;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(m). A total of m nodes need to be traversed. Here, 
 * 						   m represents the minimum number of nodes from the 
 * 						   two given trees.
 * 		Space complexity : O(m). The depth of the recursion tree can go up to 
 * 						   m in the case of a skewed tree. In average ccase, 
 * 						   depth will be O(logm).
 */
