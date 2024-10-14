using UnityEngine; 

namespace Lettree
{
    enum NodeState
    {
        SUCCESSFUL, 
        RUNNING, 
        FAILED
    } 
    
    public class TreeNode : MonoBehaviour 
    { 
        // run by the tree manager for all nodes when it starts, called by an event  
        protected void OnTreeInit() 
        { 
        }
        
        public NodeState RunNode()
        {
        }
    }

}