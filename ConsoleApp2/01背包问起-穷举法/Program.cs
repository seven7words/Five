using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01背包问起_穷举法
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int[] w = {0, 3, 4, 5};
            int[] p = {0, 4, 5, 6};
            Console.WriteLine(Exhaustivity(10,w,p));
            Console.ReadKey();
        }

        public static int Exhaustivity(int m,int[]w,int[]p)
        {
            int i = w.Length-1;//物品的个数
            int maxPrice = 0;
            for (int j = 0; j < Math.Pow(2,m); j++)
            {
                int weightTotal = 0;
                int priTotal = 0;
                //取得j上某一位的二进制值
                for (int k = 1; k <=i; k++)
                {
                  int result = Get2(j, k);
                    if (result == 1)
                    {
                        weightTotal += w[k];
                        priTotal += p[k];
                    }
                }
                if (weightTotal <= m&&priTotal>maxPrice)
                {
                    maxPrice = priTotal;
                }
            }
            return maxPrice;
        }
        /// <summary>
        /// 取得j上第number位上的二进制值是1还是0
        /// </summary>
        /// <param name="j"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Get2(int j,int number)
        {
            int A = j;
            int B = (int)Math.Pow(2, number - 1);
            int result = A & B;
            if (result == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
