﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        Label label = new Label();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = number1.Text;
            int m = Int32.Parse(num1);
            string num2 = number2.Text;
            int n = Int32.Parse(num2);
            int square = m * n;
            Console.WriteLine(square);
            textBox1.Text = square.ToString();
        }

        private void number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
