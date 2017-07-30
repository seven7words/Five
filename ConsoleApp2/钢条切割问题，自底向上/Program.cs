using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 钢条切割问题_自底向上
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;//切割收买的钢条的长度
            int[] result = new int[n+1];
            int[] p = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };//索引代表钢条的长度，值代表价格
           Console.WriteLine(BottomUp(2, p, result));
            Console.ReadKey();


        }

        public static int BottomUp(int n,int[] p,int[] result)
        {
            for (int i = 1; i<n+1; i++)
            {
                //下面取得钢条长度i的时候的最大收益
                int tempMaxPreice = -1;
                for (int j = 1; j <= i; j++)
                {
                    int maxPrice = p[j] + result[i-j];
                    if (maxPrice > tempMaxPreice)
                    {
                        tempMaxPreice = maxPrice;
                    }
                }
                result[i] = tempMaxPreice;
            }
            return result[n];
        }
    }
}
