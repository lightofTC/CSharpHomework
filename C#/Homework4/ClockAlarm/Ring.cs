using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAlarm
{
    public delegate void RingHandler();
    public class Ring
    {
        public event RingHandler SendMessage;
        public void OnSendMessage()
        {
            SendMessage();
        }
    }

    public class Me
    {
        public void HandleEvent()
        {
            Console.WriteLine("时间到！");
        }
        public void Register(Ring ring)
        {
            ring.SendMessage += new RingHandler(HandleEvent);
        }
    }
}
