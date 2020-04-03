using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ordertest
{
    [Serializable]
    public class Order
    {
        private List<OrderDetails> details = new List<OrderDetails>();
        public Order() { }
        public Order(uint orderId,Customer customer)
        {
            Id = orderId;
            Customer = customer;
        }
        public uint Id { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetails> Details
        {
            get => this.details;
        }
        public double Sum
        {   
            get { return details.Sum(d => d.Goods.Price * d.Quantity); }
            
        }

        public void AddDetails(OrderDetails orderDetails)
        {
            if (this.Details.Contains(orderDetails))
            {
                throw new Exception("orderDetails" + orderDetails.Id + " is already existed!");
            }
            details.Add(orderDetails);
        }
        public void RemoveDetails(uint orderDetailsId)
        {
            details.RemoveAll(d => d.Id == orderDetailsId);
        }
        public override string ToString()
        {
            string result = " \n";
            result += "OrderId" + Id + " Customer" + Customer;
            details.ForEach(od => result += "\n\t" + od);
            result += " \n";
            return result;
        }
    }
}
