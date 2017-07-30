using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 活动选择_贪心算法___迭代
{
    class Program
    {
        static void Main(string[] args)
        {
            //开始时间
            int[] s = { 0, 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12 };
            //结束时间
            int[] f = { 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int startTime = 0;
            int endTime = 24;
            List<int> list = new List<int>();
            for (int number = 0; number <=11; number++)
            {
                if (s[number] >= startTime && f[number] <= endTime)
                {
                    list.Add(number);
                    startTime = f[number];
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        
    
    }
}
