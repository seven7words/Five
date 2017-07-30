using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 钢条切割_带备忘的自顶向下法
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;//切割收买的钢条的长度
            int[] result = new int[n+1];
            int[] p = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };//索引代表钢条的长度，值代表价格
            Console.WriteLine(UpDown(7, p,result));
            Console.ReadKey();
        }
        /// <summary>
        /// 带备忘的自顶向下法
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static int UpDown(int n, int[] p,int[] result)
        {
            if (n == 0)
                return 0;
            if (result[n] != 0)
                return result[n];
            int tempMax = 0;
            for (int i = 1; i < n + 1; i++)
            {
                int maxPrice = p[i] + UpDown(n - i, p,result);
                if (maxPrice > tempMax)
                {
                    tempMax = maxPrice;
                }
            }
            result[n] = tempMax;
            return tempMax;

        }
    }
}
