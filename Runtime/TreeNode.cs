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
         protected List<TreeNode> children; 
         public NodeState state { public get; private set; }
         
         Start()
         {
              children = new();
         }

         // add child 
         // remove child 
         // abort 
         // Tick function 
    }

} 
