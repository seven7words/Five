using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉排序树_链式存储
{
    class BSNode
    {
        public BSNode LeftChild;
        public BSNode RightChild;
        public BSNode Parent;
        public int Data;

        public BSNode()
        {
            
        }

        public BSNode(int item)
        {
            this.Data = item;
        }
    }
}
