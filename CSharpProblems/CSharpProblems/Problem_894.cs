/*
 * Problem 894: All Possible Full Binary Trees
 * Difficulty: Medium
 * 
 * A full binary tree is a binary tree where each node has exactly 0 or 2 children.
 * 
 * Return a list of all possible full binary trees with N nodes.  
 * Each element of the answer is the root node of one possible tree.
 * 
 * Each node of each tree in the answer must have node.val = 0.
 * 
 * You may return the final list of trees in any order.
 * 
 * Example 1:
 * Input: 7
 * Output: [[0,0,0,null,null,0,0,null,null,0,0],[0,0,0,null,null,0,0,0,0],[0,0,0,0,0,0,0],[0,0,0,0,0,null,null,null,null,0,0],[0,0,0,0,0,null,null,0,0]]
*/

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_894
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
            public IList<TreeNode> AllPossibleFBT(int N)
            {
                Dictionary<int, List<TreeNode>> memo = new Dictionary<int, List<TreeNode>>();
                return FirstBreadthTraversal(N, memo);
            }

            private List<TreeNode> FirstBreadthTraversal(int num, Dictionary<int, List<TreeNode>> memo)
            {
                if (memo.ContainsKey(num))
                {
                    return memo[num];
                }

                List<TreeNode> allFBT = new List<TreeNode>();

                if (num == 1)
                {
                    allFBT.Add(new TreeNode(0));
                }
                else if (num % 2 == 1)
                {
                    for (int left = 0; left < num; left++)
                    {
                        int right = num - 1 - left;
                        foreach (TreeNode leftTreeNode in FirstBreadthTraversal(left, memo))
                        {
                            foreach (TreeNode rightTreeNode in FirstBreadthTraversal(right, memo))
                            {
                                TreeNode node = new TreeNode(0);
                                node.left = leftTreeNode;
                                node.right = rightTreeNode;
                                allFBT.Add(node);
                            }
                        }
                    }
                }

                memo.Add(num, allFBT);
                return memo[num];
            }
        }
    }
}