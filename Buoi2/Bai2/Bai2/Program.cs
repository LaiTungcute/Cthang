using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap kich thuoc mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = a[0], min = a[0], sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (max < a[i]) max = a[i];
                if (min > a[i]) min = a[i];
            }
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("So lon nhat la: " + max);
            Console.WriteLine("So nho nhat la: " + min);
            Console.WriteLine("Tong cac phan tu la: " + sum);
        }
    }
}
