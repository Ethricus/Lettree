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
         public TreeNode[] children { public get; private set; 
         public NodeState state { public get; private set; }
         
         void Start()
         {
              children = new();
         }

        public TreeNode GetChildNode(int index)
        {
            return children[index];
        }

        public List<T> GetChildNodes<T>()
        {
        }

        public bool HasChildOfType<T>()

        public bool HasChildren()
    }

} 
