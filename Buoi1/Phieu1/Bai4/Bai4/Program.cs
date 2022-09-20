using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int BacLuong, NgayCong, PhuCap, NCTL, TienLinh;
            Console.Write("Nhap bac luong: ");
            BacLuong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ngay cong: ");
            NgayCong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            PhuCap = Convert.ToInt32(Console.ReadLine());
            if (NgayCong < 25) NCTL = NgayCong;
            else NCTL = 25 + (NgayCong - 25) * 2;
            
            TienLinh = BacLuong * 1490000 * NCTL + PhuCap;
            Console.WriteLine("Tien thuc linh la: " + TienLinh);
        }
    }
}
