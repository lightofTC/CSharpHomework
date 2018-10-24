﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
    [Serializable]
    public class Goods
    {
        public Goods() { }
        private double price;
        public Goods(uint id, string name, double value)
        {
            Id = id;
            Name = name;
            Price = value;
        }
        public uint Id{ get; set; }
        public string Name { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Value cannot <0！");
                price = value;
            }
        }
        public override string ToString()
        {
            return "Id: "+Name+",Value: "+price;
        }
    }
}
