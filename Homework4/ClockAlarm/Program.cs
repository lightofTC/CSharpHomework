using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring();
            Me me = new Me();
            me.Register(ring);

            Console.WriteLine("请输入设定的日期（格式  ****/**/* **:**:**   例如2018/10/9 18:00:00）");
            String setTime = Console.ReadLine();
            System.Timers.Timer tmr = new System.Timers.Timer(1000);
            tmr.Elapsed += delegate
            {
                if (DateTime.Now.ToString() == setTime)
                {
                    ring.OnSendMessage();
                }
            };
            tmr.Start();
            Console.ReadLine();        
        }
    }
}
