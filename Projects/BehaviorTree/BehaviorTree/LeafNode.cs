using System;
namespace BT
{
    public abstract class LeafNode : BTNode
    {

        private string name;
        private BTStatus tick;

        public LeafNode(string n) 
        {
            this.name = n;

        }
        public void setTick(BTStatus s)
        {
            tick = s;
        }
        public BTStatus getTick()
        {
            return tick;
        }


    }
}
