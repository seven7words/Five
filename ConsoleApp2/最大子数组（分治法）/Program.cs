using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最大子数组_分治法_
{
    class Program
    {
        /// <summary>
        /// 最大子数组结构体
        /// </summary>
        struct SubArray
        {
            public int startIndex;
            public int endIndex;
            public int total;
        }
        static void Main(string[] args)
        {
            int[] priceArray = { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int[] priceFluctuationArray = new int[priceArray.Length - 1];//价格波动数组
            for (int i = 1; i < priceArray.Length; i++)
            {
                priceFluctuationArray[i - 1] = priceArray[i] - priceArray[i - 1];
                Console.WriteLine(priceFluctuationArray[i - 1]);
            }
            SubArray subArray = GetMaxArray(priceFluctuationArray, 0, priceFluctuationArray.Length-1);
            Console.WriteLine((subArray.startIndex-1)+"Fff"+(subArray.endIndex+1)+"fff"+subArray.total);
            Console.ReadKey();
        }
        /// <summary>
        /// 取得从low到high的最大子数组
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        static SubArray GetMaxArray(int[] array, int low, int high)
        {
            if (low == high)
            {
                SubArray subArray;
                subArray.startIndex = low;
                subArray.endIndex = high;
                subArray.total = array[low];
                return subArray;
            }
            int mid = (low + high) / 2;//低区间[low ,mid],高区间[mid+1,high]
            SubArray subArray1= GetMaxArray(array,low,mid);
            SubArray subArray2 = GetMaxArray(array, mid + 1, high);
            //从low mid找到最大子数组[i,mid]
            int total1 = array[mid];
            int startIndex = mid+1;
            int totalTemp = 0;
            for (int i = mid; i >=low; i--)
            {
                totalTemp += array[i];
                if (totalTemp > total1)
                {
                    total1 = totalTemp;
                    startIndex = i;
                }
            }
            //从mid+1 high找到最大子数组[mid+1,j]
            int  total2 = array[mid + 1];
            totalTemp = 0;
            int endIndex = mid + 1;
            for (int j = mid+1; j <=high; j++)
            {
                totalTemp += array[j];
                if (totalTemp > total2)
                {
                    total2 = totalTemp;
                    endIndex = j;
                }
            }

            SubArray subArray3;
            subArray3.startIndex = startIndex;
            subArray3.endIndex = endIndex;
            subArray3.total = total1 + total2;

            if (subArray1.total >= subArray2.total && subArray1.total >= subArray3.total)
            {
                return subArray1;
            }else if(subArray2.total >= subArray1.total && subArray2.total >= subArray3.total)
            {
                return subArray2;
            }
            else
            {
                return subArray3;
            }


        }
    }
}
