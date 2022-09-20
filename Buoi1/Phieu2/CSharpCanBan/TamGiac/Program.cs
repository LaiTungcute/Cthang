using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Nhap a= ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap c= ");
            c = Convert.ToSingle(Console.ReadLine());
            if (a <= 0 || b <= 0 || c <= 0) Console.WriteLine("Khong phai la 1 tam giac");
            else if (a + b == c) Console.WriteLine("Khong phai la tam giac");
            else
            {
                float P = (a + b + c) / 2;
                Console.WriteLine("Chu vi tam giac la: " + (a+b+c));
                Console.WriteLine("Dien tich tam giac la: " + (Math.Sqrt(P*(P-a)*(P-b)*(P-c))));
            }
        }
    }
}
