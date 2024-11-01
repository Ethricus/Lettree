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
         protected TreeNode[] children; 
         public NodeState state { public get; private set; }

         // add child 
         // remove child 
         // abort 
         // Tick function 
    }

} 
