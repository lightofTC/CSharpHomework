using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2HomeworkText9
{
    class Text9
    {
        static void Main(string[] args)
        {
            int i ,j= 0;
            int[] array=new int [101];


            for (i = 1; i <=100; i++)
            {
                array[i] = i;
            }
            array[1] = 0;


            for (i = 2; i <= 100; i++)
            {
                if(array[i] != 0)
                {
                    for (j = i + 1; j <= 100; j++)
                    {
                        if(array[j] != 0 && array[j] % array[i] == 0)
                        {
                            array[j] = 0;
                        }
                    }
                }
            }


            Console.Write("素数有：");
            for (i = 2; i < 101; i++)
            {
                if(array[i] != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
