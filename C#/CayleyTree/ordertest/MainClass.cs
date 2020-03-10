using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
    class MainClass
    {
        static void Main(string[] args)
        {
            try
            {
                Customer customer1 = new Customer(1, "Customer1");
                Customer customer2 = new Customer(2, "Customer2");

                Goods Computer = new Goods(1, "Computer", 5999);
                Goods Phone = new Goods(2, "Phone", 2399);
                Goods PSP = new Goods(3, "PSP", 1500);

                OrderDetails orderDetails1 = new OrderDetails(1, Computer, 1);
                OrderDetails orderDetails2 = new OrderDetails(2, Phone, 2);
                OrderDetails orderDetails3 = new OrderDetails(3, PSP, 2);

                Order order1 = new Order(1, customer1);
                Order order2 = new Order(2, customer2);
                Order order3 = new Order(3, customer1);

                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);

                order2.AddDetails(orderDetails3);
                order2.AddDetails(orderDetails1);

                order3.AddDetails(orderDetails2);
                order3.AddDetails(orderDetails1);

                OrderService os = new OrderService();
                os.AddOrder(order1);
                os.AddOrder(order2);
                os.AddOrder(order3);

                Console.WriteLine("GetAllOrders");
                List<Order> orders = os.QueryAllOrders();
                foreach (Order od in orders)
                    Console.WriteLine(od.ToString());

                Console.WriteLine("SearchOrdersByPrice");
                orders = os.SearchOrdersByPrice(10000);
                foreach (Order od in orders)
                    Console.WriteLine(od.ToString());

                Console.WriteLine("SearchOrdersByGoodsName");
                orders = os.SearchOrderByGoodsName("PSP");
                foreach (Order od in orders)
                    Console.WriteLine(od.ToString());

                Console.WriteLine("XMLSerialize");
                os.Export(os);
                os.Import();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
