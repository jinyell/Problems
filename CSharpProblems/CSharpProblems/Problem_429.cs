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
    public class Problem_429
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
                IList<IList<int>> result = new List<IList<int>>();
                if (root == null)
                {
                    return result;
                }

                Queue<ChildrenNode> queue = new Queue<ChildrenNode>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    int level = queue.Count;
                    IList<int> subList = new List<int>();
                    for (int i = 0; i < level; i++)
                    {
                        ChildrenNode node = queue.Dequeue();
                        subList.Add(node.val);

                        foreach (ChildrenNode child in node.children)
                        {
                            queue.Enqueue(child);
                        }
                    }
                    result.Add(subList);
                }
                return result;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
