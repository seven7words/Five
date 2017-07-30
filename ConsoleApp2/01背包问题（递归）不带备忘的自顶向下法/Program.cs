using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01背包问题_递归_不带备忘的自顶向下法
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int[] w = { 0, 3, 4, 5 };
            int[] p = { 0, 4, 5, 6 };
            Console.WriteLine(UpDown(10,3,w,p));
            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">背包容量</param>
        /// <param name="i">物品个数</param>
        /// <param name="w">物品重量数组</param>
        /// <param name="p">价值数组</param>
        /// <returns></returns>
        public static int UpDown(int m,int i,int [] w,int[] p)//m返回值是m可以存储的最大价值
        {
            if (i == 0 || m == 0)
                return 0;
            if (w[i] > m)
            {
                return UpDown(m, i - 1, w, p);
            }
            else
            {
                int maxValue1 = UpDown(m - w[i], i - 1, w, p) + p[i];
                int maxValue2 = UpDown(m, i - 1, w, p);
                if (maxValue1 > maxValue2)
                {
                    return maxValue1;
                }
                return maxValue2;
            }
        }
    }
}
