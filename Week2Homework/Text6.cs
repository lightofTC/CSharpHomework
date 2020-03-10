using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Homework
{
    class Text6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数： ");
            string num = "";
            num = Console.ReadLine();
            long m= 0;
            m = Int32.Parse(num);
            if (m < 2)
            {
                Console.WriteLine("没有小于" + m + "的素数");
            }
            Console.Write("素数有：2 ");
            int i, j ,k= 0;
            for (i = 1; i <= m; i+=2)
            {
                for(j=2;j<i; j++)
                {
                    k = i % j;                   
                    if (k == 0)
                    {
                        break;
                    }
                    if (j == i-1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
