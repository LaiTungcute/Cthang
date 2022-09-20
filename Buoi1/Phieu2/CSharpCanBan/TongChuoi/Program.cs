using System;

namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //s = 1+2+...+n
            int s = 0;
            int n;
            Console.Write("Nhap n= ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                s += i;
            }
            Console.WriteLine("s= " + s);

            float s1 = 0;
            for(int i=1;i<=n;i++)
            {
                s1 += (float) 1 / i;
            }
            Console.WriteLine("s1= " + s1);
        }
    }
}
