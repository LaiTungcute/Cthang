using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai, rong;
            Console.Write("Nhap chieu dai: ");
            dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            rong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chu vi hinh chu nhat la: " + ((dai+rong)*2));
            Console.WriteLine("Dien tich hinh chu nhat la: " + (dai * rong));
        }
    }
}
