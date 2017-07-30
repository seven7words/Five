using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动态规划_钢条切割
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;//切割收买的钢条的长度
            int[] p = {0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30};//索引代表钢条的长度，值代表价格
            Console.WriteLine(UpDown(7,p));

        }

        public static int UpDown(int n,int[] p)
        {
            if (n == 0)
                return 0;
            int tempMax = 0;
            for (int i = 1; i < n+1; i++)
            {
                int maxPrice = p[i] + UpDown(n - i,p);
                if (maxPrice > tempMax)
                {
                    tempMax = maxPrice;
                }
            }
            return tempMax;

        }
    }
}
