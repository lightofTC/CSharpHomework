using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = null;
            Console.WriteLine("请从以下选项中输入您所需要计算的图形的面积：“Circle”(圆)，“Triangle”（三角形），“Rectangle”（长方形)，“Square”(正方形）");
            string s = Console.ReadLine();
            shape = ShapeFactory.GetShape(s);
            shape.Print(s);
        }
    }
}
