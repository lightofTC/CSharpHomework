using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6
{
    public partial class MenuForm : Form  
    {
        Customer customer1 = new Customer(1, "Customer1");
        Customer customer2 = new Customer(2, "Customer2");

        Goods Computer = new Goods(1, "Computer", 5999);
        Goods Phone = new Goods(2, "Phone", 2399);
        Goods PSP = new Goods(3, "PSP", 1500);
       
        public MenuForm()
        {
            InitializeComponent();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails1 = new OrderDetails(1, Computer, 1);
            OrderDetails orderDetails2 = new OrderDetails(2, Phone, 2);
            OrderDetails orderDetails3 = new OrderDetails(3, PSP, 2);
            if (comboBox1.Equals("Customer1"))
            {
                Order order1 = new Order(1, customer1);
                foreach(object obj in checkedListBox1.Controls)
                {
                    if(obj is CheckBox && ((CheckBox)obj).Checked)
                    {
                        order1.AddDetails(orderDetails1);
                    }
                }
            }
           else
            {
                Order order2 = new Order(2, customer2);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
