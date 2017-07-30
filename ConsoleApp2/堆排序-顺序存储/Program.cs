using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆排序_顺序存储
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {50, 10, 90, 30, 70, 40, 80, 60, 20};
            HeapSort(data);
            foreach (int i in data)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        public static void HeapSort(int[] data)
        {
            for (int i =  data.Length / 2; i>=1;i--)//遍历这个数的所有非叶节点挨个把所有的子书变为子大顶堆
            {
               HeapAdjust(i,data,data.Length);
                
            }
            //经过上面的，把二叉树变成大顶堆
            for (int i = data.Length; i >1; i--)
            {
                //把编号1和i位置进行交换

                //1到i-1构造成大顶堆
                int temp1 = data[0];
                data[0] = data[i - 1];
                data[i - 1] = temp1;
                HeapAdjust(1,data,i-1);
            }
        }

        public static void HeapAdjust(int numberToAjust, int[] data, int maxNumber)
        {
            int maxNodeNumber = numberToAjust;//最大节点的编号
            int tempI = numberToAjust;
            while (true)
            {
                //把i节点的子树变成大顶堆

                int leftChildNumber = tempI * 2;
                int rightChildNumber = leftChildNumber + 1;
                if (leftChildNumber <= maxNumber && data[leftChildNumber - 1] > data[maxNodeNumber - 1])
                {
                    maxNodeNumber = leftChildNumber;
                }
                if (rightChildNumber <= maxNumber && data[rightChildNumber - 1] > data[maxNodeNumber - 1])
                {
                    maxNodeNumber = rightChildNumber;
                }
                if (maxNodeNumber != tempI) //法线了一个比i更大的子节点，进行交换
                {
                    int temp = data[tempI - 1];
                    data[tempI - 1] = data[maxNodeNumber - 1];
                    data[maxNodeNumber - 1] = temp;
                    tempI = maxNodeNumber;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
