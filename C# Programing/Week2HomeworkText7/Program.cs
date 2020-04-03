using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2HomeworkText7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 2, 5, 9, 3, 7 };
            int i, k = 0;
            int length = array.Length;
              

            for (i = 0; i < length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    k = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = k;
                }
            }
            Console.WriteLine("最大值：" + array[length - 1]);


            for (i = 0; i < length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    k = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = k;
                }
            }
            Console.WriteLine("最小值：" + array[length - 1]);


            for(i = 0; i < length - 1; i++)
            {
                k = k + array[i];
            }
            Console.WriteLine("所有元素的和：" + k);
            double j = k / length;
            Console.WriteLine("平均值：" + j);
        }
    }
}
