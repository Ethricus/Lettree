using System;
using System.Collections.Generic;
using System.Linq;

namespace Lettree.Runtime
{
    public enum NodeState
    {
        INACTIVE,
        RUNNING,
        SUCCESS,
        FAILURE
    }

    class TreeNode
    {
        protected TreeNode parent;
        public TreeNode[] children { get; private set; }
        public NodeState state { get; private set; }
        public bool HasChildren { get { return children.Length > 0; } }

        void Start()
        {
            //children = new();
        }

        public TreeNode GetChildNode(int index)
        {
            return children[index];
        }

        public List<T> GetChildNodes<T>() where T : TreeNode
        {
            return null;
        }

        public bool HasChildOfType<T>() where T : TreeNode
        {
            foreach (TreeNode node in children)
            {
                if (node is T)
                    return true;
            }
            return false;
        }
    }
}
