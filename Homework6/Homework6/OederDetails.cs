using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails() { }
        public OrderDetails(uint id, Goods goods, uint quantity)
        {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
        }    
        public uint Id { get; set; }
        public Goods Goods { get; set; }
        public uint Quantity { get; set; }

        public override int GetHashCode()
        {
            var hashCode = 55555555;
            hashCode = (hashCode * -55555) + Goods.Name.GetHashCode();
            hashCode = (hashCode * -55555) + Quantity.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            string result = "";
            result += "orderDetailId: " + Id;
            result += Goods + ", quantity: " + Quantity;
            return result;
        }
        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetails;
            return detail != null && Goods.Id == detail.Goods.Id && Quantity == detail.Quantity;
        }


    }
}
