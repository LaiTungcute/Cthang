using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PT bac nhat
            int a, b;
            Console.Write("Nhap a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Phuong trinh vo so nghiem");
                else Console.WriteLine("Phuong trinh vo nghiem");
            }
            else Console.WriteLine("Phuong trinh co nghiem la: x= " + (-b/a));

            //PT bac 2
            int c;
            Console.Write("Nhap a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c= ");
            c = Convert.ToInt32(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet la: ");
                Console.WriteLine("x1= " + ((-b + Math.Sqrt(delta)) / (2 * a)));
                Console.WriteLine("x1= " + ((-b - Math.Sqrt(delta)) / (2 * a)));
            }
            else if (delta == 0) Console.WriteLine("Phuong trinh co 2 nghiem kep: x1= x2= " + (-b / (2 * a)));
            else Console.WriteLine("Phuong trinh vo nghiem");
        }
    }
}
