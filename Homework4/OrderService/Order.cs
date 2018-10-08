using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    public class OrderService
    {   
    }
    public class Order
    {
        ArrayList OrderNumber = new ArrayList(3);
        ArrayList OrderName = new ArrayList(3);
        ArrayList OrderCustomor = new ArrayList(3);

        public void Menu()
        {
            Console.WriteLine("请输入您所需要执行的操作：");
            Console.WriteLine("1.添加订单");
            Console.WriteLine("2.删除订单");
            Console.WriteLine("3.修改订单");
            Console.WriteLine("4.查询订单");
        }

        public void Input()
        {
            Console.Write("订单号：\t");
            OrderNumber.Add(Console.ReadLine());
            Console.Write("商品名称：\t");
            OrderName.Add(Console.ReadLine());
            Console.Write("客户：\t");
            OrderCustomor.Add(Console.ReadLine());
        }

        public void Delete(int i)
        {
            OrderNumber.RemoveAt(i);
            OrderName.RemoveAt(i);
            OrderCustomor.RemoveAt(i);
        }

        public void Show(int i)
        {

        }

        public void change(int i)
        {

        }

        public void start()
        {
            Order order = new Order();
        Return: 
            order.Menu();
            string task = Console.ReadLine();
            int num = Int32.Parse(task);
            switch (num)
            {
                case 1:
                    Input();
                    goto Return;
                case 2:
                    Delete(num);
                    goto Return;

            }
        }
    }    
}
