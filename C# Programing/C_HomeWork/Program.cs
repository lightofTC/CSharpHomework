using System;

namespace C_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            int m = 0, n = 0;
            Console.WriteLine("Please input an int as you like:");
            number = Console.ReadLine();
            m = Int32.Parse(number);
            Console.WriteLine("Please input an int again as you like:");
            number = Console.ReadLine();
            n = Int32.Parse(number);
            m = m * n;
            Console.WriteLine("The anwser is: " + m );
        }
    }
}
