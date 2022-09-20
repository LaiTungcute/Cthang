
using System;

namespace Phieu
{
    class Program
    {
        static int UCLN(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap tu: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            b = int.Parse(Console.ReadLine());

            c = UCLN(a, b);
            a = a / c;
            b = b / c;

            Console.WriteLine("Phan so sau khi rut gon: {0}/{1}", a, b);
        }
    }
}
