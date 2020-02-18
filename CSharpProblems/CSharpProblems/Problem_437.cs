/*
 * Problem 437: Path Sum III
 * Difficulty: Easy
 * 
 * You are given a binary tree in which each node contains an integer value.
 * 
 * Find the number of paths that sum to a given value.
 * 
 * The path does not need to start or end at the root or a leaf, but it 
 * must go downwards (traveling only from parent nodes to child nodes).
 * 
 * The tree has no more than 1,000 nodes and the values are in the 
 * range -1,000,000 to 1,000,000.
 * 
 * Example:
 * 
 *      root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8
 * 
 *            10
 *           /  \
 *          5   -3
 *         / \    \
 *        3   2   11
 *       / \   \
 *      3  -2   1
 * 
 *      Return 3. The paths that sum to 8 are:
 * 
 *      1.  5 -> 3
 *      2.  5 -> 2 -> 1
 *      3. -3 -> 11
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_437
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
            public int PathSum(TreeNode root, int sum)
            {
                Dictionary<int, int> presum = new Dictionary<int, int>();
                presum.Add(0, 1);
                return CountPaths(root, 0, sum, presum);
            }

            private int CountPaths(TreeNode root, int currentSum,
                                   int targetSum, Dictionary<int, int> presum)
            {
                if (root == null) { return 0; }

                currentSum += root.val;
                int result = 0;
                if (presum.ContainsKey(currentSum - targetSum))
                {
                    result = presum[currentSum - targetSum];
                }
                int addCount = (presum.ContainsKey(currentSum)) ?
                                                    presum[currentSum] : 0;
                presum[currentSum] = addCount + 1;

                result += CountPaths(root.left, currentSum, targetSum, presum)
                       + CountPaths(root.right, currentSum, targetSum, presum);
                presum[currentSum] = presum[currentSum] - 1;
                return result;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
