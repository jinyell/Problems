using System.Collections.Generic;

namespace CSharpProblems
{
    // Definition for a Node.
    public class NeighborNode
    {
        public int val;
        public IList<NeighborNode> neighbors;

        public NeighborNode() { }
        public NeighborNode(int _val, IList<NeighborNode> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }