using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n= ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine("n la so chan");
            else Console.WriteLine("n la so le");
            if (n < 0) Console.WriteLine("n la so am");
            else Console.WriteLine("n la so khong am");
        }
    }
}
