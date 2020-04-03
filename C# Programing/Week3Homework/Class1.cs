using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    public abstract class Shape
    {
        protected string s = null;
        protected double radius = 0;
        protected double a = 0;
        protected double b = 0;
        protected double square = 0;
        public abstract void Print(string shape);
        
    }

  public class Circle : Shape
    {
        public override void Print(string shape)
        {
            Console.WriteLine("请输入"+shape+"的半径：");
            s = Console.ReadLine();
            radius = double.Parse(s);
            square = 3.14 * radius * radius;
            Console.WriteLine(shape + "的面积：" +square);
        }
    }
    public class Rectangle : Shape
    {
        public override void Print(string shape)
        {
            Console.WriteLine("请输入"+shape+"的长（底）：");
            s = Console.ReadLine();
            a = double.Parse(s);
            Console.WriteLine("请输入"+shape+"的宽（高）：");
            s = Console.ReadLine();
            b = double.Parse(s);
            square = a * b;
            Console.WriteLine(shape + "的面积：" + square);          
        }
    }
    public class InputException : Shape
    {
        public override void Print(string shape)
        {
            Console.WriteLine("输入无效！");
        }
      
    }

    class ShapeFactory
    {
        public static Shape GetShape(string arg) {
            Shape shape = null;
            
                if (arg.Equals("Circle"))
                {
                    shape = new Circle();
                }
                if (arg.Equals("Rectangle") || arg.Equals("Triangle") || arg.Equals("Square"))
                {
                    shape = new Rectangle();
                }
            else
            {
                shape = new InputException();
            }
                return shape;
           
                
                
            

        }

       
    }
}
