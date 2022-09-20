using System;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n= ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1) Console.WriteLine("n khong la so nguyen to");
            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if (n % i == 0) Console.WriteLine("n khong la so nguyen to");
                else Console.WriteLine("n la so nguyen to");
            }
        }
    }
}
