using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BT
{
    //Abstract Class: Behaviour Tree Node
    public abstract class BTNode
    {
       
        //Decision status of the node
        public abstract BTStatus Tick();
    }

}
