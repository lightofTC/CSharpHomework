using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


    namespace Homework6
    {

        [Serializable]
        public class OrderService
        {

            private Dictionary<uint, Order> orderDict;
            public OrderService()
            {
                orderDict = new Dictionary<uint, Order>();
            }
            public void AddOrder(Order order)
            {
                if (orderDict.ContainsKey(order.Id))
                    throw new Exception("order " + order.Id + " is already existed!");
                orderDict[order.Id] = order;
            }
            public void RemoveOrder(uint orderId)
            {
                orderDict.Remove(orderId);
            }
            public List<Order> QueryAllOrders()
            {
                return orderDict.Values.ToList();
            }
            public Order GetById(uint orderId)
            {
                return orderDict[orderId];
            }
            public List<Order> QueryByGoodsName(string goodsName)
            {
                List<Order> result = new List<Order>();
                foreach (Order order in orderDict.Values)
                {
                    foreach (OrderDetails detail in order.Details)
                    {
                        if (detail.Goods.Name == goodsName)
                        {
                            result.Add(order);
                            break;
                        }
                    }
                }
                return result;
            }
            public List<Order> QueryByCustomerName(string customerName)
            {
                var query = orderDict.Values
                    .Where(order => order.Customer.Name == customerName);
                return query.ToList();
            }
            public void UpdateCustomer(uint orderId, Customer newCustomer)
            {
                if (orderDict.ContainsKey(orderId))
                {
                    orderDict[orderId].Customer = newCustomer;
                }
                else
                {
                    throw new Exception("order " + orderId + " is not existed!");
                }
            }
            public List<Order> SearchOrderByGoodsName(string goodsName)
            {
                var search = orderDict.Values.Where(order => order.Details.Where(d => d.Goods.Name == goodsName).Count() > 0);
                return search.ToList();
            }
            public List<Order> SearchOrdersByCustomer(string customerName)
            {
                var search = orderDict.Values.Where(order => order.Customer.Name == customerName);
                return search.ToList();

            }
            public List<Order> SearchOrdersByPrice(double price)
            {
                var search = orderDict.Values.Where(order => order.Sum >= price);
                return search.ToList();
            }

            string xmlFileName = "OrderService.xml";
            public void Export(OrderService order)
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(OrderService[]));
                XmlSerialize(xmlser, xmlFileName, order);
            }
            public void Import()
            {
                string xml = File.ReadAllText(xmlFileName);
                Console.WriteLine(xml);
            }

            private static void XmlSerialize(XmlSerializer ser, string fileName, OrderService order)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                ser.Serialize(fs, order);
                fs.Close();
            }
        }
    }
