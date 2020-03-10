using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 400, 410, 100, -Math.PI / 2);
        }
        private Graphics graphics;
        int color = 0;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double k = Double.Parse(textBox1.Text);
            double per1 = Double.Parse(textBox2.Text);
            double per2 = Double.Parse(textBox3.Text);
            double th1 = Double.Parse(textBox5.Text) * Math.PI / 180;
            double th2 = Double.Parse(textBox6.Text) * Math.PI / 180;

            double x1 = x0 + leng * k *  Math.Cos(th);
            double y1 = y0 + leng * k * Math.Sin(th);

            if (color == 4)
            { color = 0; }
            color++;
            drawLine(x0, y0, x1, y1,color);     

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        
        private void drawLine(double x0, double y0, double x1, double y1,int color)
        {
            switch (color)
            {
                case 0: graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case 1: graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case 2: graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case 3: graphics.DrawLine(Pens.Orange, (int)x0, (int)y0, (int)x1, (int)y1); break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
