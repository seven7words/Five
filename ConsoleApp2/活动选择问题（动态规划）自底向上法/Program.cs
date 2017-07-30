using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 活动选择问题_动态规划_自底向上法
{
    class Program
    {
        static void Main(string[] args)
        {
            //开始时间
            int[] s = {0, 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12, 24};
            //结束时间
            int[] f = {0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 24};
            List<int>[,] result = new List<int>[13,13];//默认值null
            for (int m = 0; m < 13; m++)
            {
                for (int n = 0; n < 13; n++)
                {
                    //默认值是空List集合
                    result[m,n] = new List<int>();
                }
            }
            for (int j = 0; j < 13; j++)
            {
                for (int i = 0; i < j-1; i++)
                {
                    //S[i,j]i活动结束后，j活动开始前的活动集合
                    //f[i] s[j]这个时间区间内的所有活动
                    List<int>sij = new List<int>();
                    for (int number = 1; number < s.Length-1; number++)
                    {
                        if (s[number] >= f[i] && f[number] <= s[j])
                        {
                            sij.Add(number);
                        }
                    }
                    if (sij.Count > 0)
                    {
                        //result[i,j] = max{result[i,k]+result[k,j]+k}
                        int maxCount = 0;
                        List<int> tempList = new List<int>();
                        foreach (int number in sij)
                        {
                            int count = result[i, number].Count + result[number, j].Count + 1;
                            if (maxCount < count)
                            {
                                maxCount = count;
                                tempList = result[i, number].Union<int>(result[number, j]).ToList();
                                tempList.Add(number);
                            }
                        }
                        result[i, j] = tempList;
                    }
                }
            }
            List<int> l = result[0, 12];
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(result[0,12]);
            Console.ReadKey();
        }

    }
}
