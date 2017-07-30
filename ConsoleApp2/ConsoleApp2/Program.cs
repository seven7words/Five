using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceArray = {100, 113,110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97};
            int[] priceFluctuationArray = new int[priceArray.Length-1];//价格波动数组
            for (int i = 1; i < priceArray.Length; i++)
            {
                priceFluctuationArray[i - 1] = priceArray[i] - priceArray[i - 1];
                Console.WriteLine(priceFluctuationArray[i-1]);
            }
            int total = priceFluctuationArray[0];//默认数组第一个元素是最大子数组
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < priceFluctuationArray.Length; i++)
            {
                //取得以i为子数组起点的所有子数组
                for (int j = i; j < priceFluctuationArray.Length; j++)
                {
                    int totalTemp = 0;//临时最大子数组的和
                    for (int k = i; k < j+1; k++)
                    {
                        totalTemp += priceFluctuationArray[k];
                    }
                    if (totalTemp>total)
                    {
                        total = totalTemp;
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }
            Console.WriteLine(startIndex+"fff"+(endIndex+1));
            Console.ReadKey();
        }
    }
}
