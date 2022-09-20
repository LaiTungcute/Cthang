using System;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n= ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                if (i % 5 == 0) continue;
                Console.Write(i + " ");
            }
        }
    }
}
