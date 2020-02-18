using System.Collections.Generic;

namespace CSharpProblems
{
    // Definition for a Node.
    public class ChildrenNode
    {
        public int val;
        public IList<ChildrenNode> children;

        public ChildrenNode() { }
        public ChildrenNode(int _val, IList<ChildrenNode> _children)
        {
            val = _val;
            children = _children;
        }
    }
}