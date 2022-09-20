using System;

namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            float diem;
            Console.Write("Nhap ten hoc sinh: ");
            name = Console.ReadLine();
            Console.Write("Nhap diem: ");
            diem = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ho va ten: " + name.ToUpper());
            if (diem >= 8) Console.WriteLine("Gioi");
            else if (diem >= 6.5 && diem < 8) Console.WriteLine("Kha");
            else if (diem >= 5 && diem < 6.5) Console.WriteLine("Trung binh");
            else Console.WriteLine("Yeu");
        }
    }
}
