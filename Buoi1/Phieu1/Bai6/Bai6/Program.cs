using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n= ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n<=0)
            {
                Console.WriteLine(n);
                if (n<0) n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
