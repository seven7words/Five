using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树_完全顺序存储
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] data = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};//存储的顺序结构
            BiTree<char> tree = new BiTree<char>(10);
            for (int i = 0; i < data.Length; i++)
            {
                tree.Add(data[i]);
            }
            tree.FirstTraversal();
            tree.MiddleTraversal();
            tree.LastTraversal();
            tree.LayerTraversal();
            Console.ReadKey();
        }
    }
}
