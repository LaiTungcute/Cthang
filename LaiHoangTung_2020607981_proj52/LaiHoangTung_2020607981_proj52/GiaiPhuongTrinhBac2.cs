using System;
using System.Collections.Generic;
using System.Text;

namespace LaiHoangTung_2020607981_proj52
{
    class GiaiPhuongTrinhBac2
    {
        private int a, b, c;
        public GiaiPhuongTrinhBac2 ()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void tinh()
        {
            int delta = b * b - 4 * a * c;
            if(delta == 0)
            {
                Console.WriteLine($"Phuong trinh co 2 nghiem kep: x1 = x2 = {(-b + Math.Sqrt(delta)) / (2 * a)}");
            }
            else if(delta >0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: " +
                    $"x1 = {(-b + Math.Sqrt(delta)) / (2 * a)}" +
                    $"x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
}
