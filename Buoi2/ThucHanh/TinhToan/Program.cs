using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            string pt;
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            pt = Console.ReadLine();
            if(pt == "+")
            {
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            }
            else if (pt == "-")
            {
                Console.WriteLine(a + " - " + b + " = " + (a - b));
            }
            else if (pt == "*")
            {
                Console.WriteLine(a + " * " + b + " = " + (a * b));
            }
            else if (pt == "/")
            {
                Console.WriteLine(a + " / " + b + " = " + (a / b));
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}
