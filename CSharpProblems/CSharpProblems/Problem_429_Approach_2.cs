/*
 * Problem 429: N-ary Tree Level Order Traversal
 * Difficulty: Easy
 *
 * Given an n-ary tree, return the level order traversal of its nodes' 
 * values. (ie, from left to right, level by level).
 * 
 * For example, given a 3-ary tree:
 * 
 *           1
 *         / | \
 *        3  2  4
 *       / \
 *      5   6
 * 
 * We should return its level order traversal:
 * 
 *      [
 *           [1],
 *           [3,2,4],
 *           [5,6]
 *      ]
 * 
 * Note:
 *     The depth of the tree is at most 1000.
 *     The total number of nodes is at most 5000.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_429_Approach_2
    {
        /*
        // Definition for a Node.
        public class Node {
            public int val;
            public IList<Node> children;

            public Node(){}
            public Node(int _val,IList<Node> _children) {
                val = _val;
                children = _children;
        }
        */
        public class Solution
        {
            public IList<IList<int>> LevelOrder(ChildrenNode root)
            {
                List<IList<int>> result = new List<IList<int>>();
                Helper(root, 0, result);
                return result;
            }

            private void Helper(ChildrenNode root, int level,
                                List<IList<int>> result)
            {
                if (root == null)
                {
                    return;
                }

                if (result.Count - 1 < level)
                {
                    result.Add(new List<int>());
                    result[level].Add(root.val);
                }
                else
                {
                    result[level].Add(root.val);
                }

                if (root.children != null)
                {
                    foreach (var node in root.children)
                    {
                        Helper(node, level + 1, result);
                    }
                }
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
