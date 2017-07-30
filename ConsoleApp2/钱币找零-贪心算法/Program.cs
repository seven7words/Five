using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 钱币找零_贪心算法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = {3, 0, 2, 1, 0, 3, 5}
                ;
            int[] amount = {1, 2, 5, 10, 20, 50, 100};
            int[] result = Change(320, count, amount);
            foreach (int i in result)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }

        public static int[] Change(int k, int[] count, int[] amount)
        {
            if (k == 0)
                return new int[amount.Length+1];
            int index = amount.Length - 1;
            int total = 0;
            int[]result = new int[amount.Length+1];
            while (true)
            {
                if(k<=0 ||index<=-1)
                    break;

                if (k > count[index] * amount[index])
                {
                    result[index] = count[index];
                    k -= count[index] * amount[index];
                }
                else
                {
                    result[index] = k / amount[index];
                    k -= result[index] * amount[index];
                }
                index--;

            }
            result[amount.Length] = k;
            return result;
        }
    }
}
