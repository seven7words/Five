using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树_完全顺序存储
{/// <summary>
/// 如果一个节点是空的话，那么这个jedi按所在的数组位置为-1
/// </summary>
/// <typeparam name="T"></typeparam>
    class BiTree<T>
    {

        private T[] data;
        private int count = 0;

        public BiTree(int capacity)//容量/
        {
            data = new T[capacity];
        }

        public bool Add(T item)
        {
            if (count >= data.Length)
                return false;
            data[count] = item;
            count++;
            return true;
        }

        public void FirstTraversal()
        {
            FirstTraversal(0);
        }
        void FirstTraversal(int index)
        {
            if(index>= count)
                return;
            
            //得到要遍历的这个节点的编号
            int number = index + 1;
            if (data[index].Equals(-1))
                return;
            Console.WriteLine(data[index]);
            //得到左节点
            int leftNumber = number * 2;
            int rightNumber = number * 2 + 1;
            FirstTraversal(leftNumber-1);
            FirstTraversal(rightNumber-1);
        }

        public void MiddleTraversal()
        {
            MiddleTraversal(0);
        }
        void MiddleTraversal(int index)
        {
            if (index >= count)
                return;

            //得到要遍历的这个节点的编号
            int number = index + 1;
            if (data[index].Equals(-1))
                return;
            //得到左节点
            int leftNumber = number * 2;
            int rightNumber = number * 2 + 1;
            MiddleTraversal(leftNumber - 1);
            Console.WriteLine(data[index]);
           
           
            MiddleTraversal(rightNumber - 1);
        }

        public void LastTraversal()
        {
            LastTraversal(0);
        }
        void LastTraversal(int index)
        {

            if (index >= count)
                return;

            //得到要遍历的这个节点的编号
            int number = index + 1;
            if (data[index].Equals(-1))
                return;
            //得到左节点
            int leftNumber = number * 2;
            int rightNumber = number * 2 + 1;
            LastTraversal(leftNumber - 1);
            


            LastTraversal(rightNumber - 1);
            Console.WriteLine(data[index]);
        }

        public void LayerTraversal()
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(-1))
                {
                    continue;
                }
                Console.WriteLine(data[i]+"");
            }
        }
    }
}
