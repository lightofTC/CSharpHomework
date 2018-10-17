using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
    class Order
    {
        private List<OrderDetails> details = new List<OrderDetails>();
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
