using LaiHoangTung_2020607981_proj51;
using System;
using System.Collections.Generic;

namespace Buoi5
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ThiSinhA> listThiSinh = new List<ThiSinhA>();
            int n;
            do
            {
                Console.WriteLine("============== Danh sach cac lua chon ================");
                Console.WriteLine("|   1. Nhap thong tin 1 thi sinh                     |");
                Console.WriteLine("|   2. Hien thi danh sach cac thi sinh               |");
                Console.WriteLine("|   3. Hien thi cac sinh vien theo tong diem         |");
                Console.WriteLine("|   4. Hien thi cac sinh vien theo dia chi           |");
                Console.WriteLine("|   5. Tim kiem theo so bao danh                     |");
                Console.WriteLine("|   6. Ket thuc                                      |");
                Console.WriteLine("======================================================");

                Console.Write("Nhap lua chon cua ban: ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        nhap(listThiSinh);
                        break;
                    case 2:
                        xuat(listThiSinh);
                        break;
                    case 3:
                        {

                            float t;
                            Console.Write("Nhap tong diem: ");
                            t = Convert.ToSingle(Console.ReadLine());
                            hienThiTongDiem(listThiSinh,t);
                            break;
                        }
                    case 4:
                        {
                            string t;
                            Console.Write("Nhap dia chi: ");
                            t = Console.ReadLine();
                            hienThiDiaChi(listThiSinh, t);
                            break;
                        }
                    case 5:
                        {
                            string t;
                            Console.Write("Nhap SBD: ");
                            t = Console.ReadLine();
                            hienThiSBD(listThiSinh, t);
                            break;
                        }
                    case 6:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Khong co tinh nang nay xin moi nhap lai");
                        break;
                }
            } while (true);
        }

        //Nhap 1 thi sinh
        static void nhap(List<ThiSinhA> listThiSinh)
        {
            ThiSinhA thiSinh = new ThiSinhA();
            Console.Write("Nhap so bao danh: ");
            thiSinh.Sbd = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            thiSinh.HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            thiSinh.DiaChi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            thiSinh.Toan = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            thiSinh.Ly = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            thiSinh.Hoa = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem uu tien: ");
            thiSinh.DiemUuTien = Convert.ToInt32(Console.ReadLine());
            thiSinh.TongDiem = thiSinh.Toan + thiSinh.Ly + thiSinh.Hoa + thiSinh.DiemUuTien;
            listThiSinh.Add(thiSinh);
        }

        //Xuat danh sach sinh vien
        static void xuat(List<ThiSinhA> thiSinhs)
        {
            Console.WriteLine("SBD".PadRight(10) + "Ho ten".PadRight(30) + "Dia chi".PadRight(30) 
                + "Diem toan".PadRight(15) + "Diem ly".PadRight(15) + "Diem hoa".PadRight(15) 
                + "Diem uu tien".PadRight(15) + "Tong diem".PadRight(15));
            for (int i = 0; i < thiSinhs.Count; i++)
            {
                Console.WriteLine(thiSinhs[i].Sbd.PadRight(10) + thiSinhs[i].HoTen.PadRight(30)
                    + thiSinhs[i].DiaChi.PadRight(30) + Convert.ToString(thiSinhs[i].Toan).PadRight(15)
                    + Convert.ToString(thiSinhs[i].Ly).PadRight(15) + Convert.ToString(thiSinhs[i].Hoa).PadRight(15)
                    + Convert.ToString(thiSinhs[i].DiemUuTien).PadRight(15) + Convert.ToString(thiSinhs[i].TongDiem).PadRight(15));
            }
        }

        //Hien thi cac sinh vien theo tong diem
        static void hienThiTongDiem(List<ThiSinhA> thiSinhs, float t)
        {
            thiSinhs.Sort();
            Console.WriteLine("SBD".PadRight(10) + "Ho ten".PadRight(30) + "Dia chi".PadRight(30) 
                + "Diem toan".PadRight(15) + "Diem ly".PadRight(15) + "Diem hoa".PadRight(15) 
                + "Diem uu tien".PadRight(15) + "Tong diem".PadRight(15));
            for (int i = 0; i < thiSinhs.Count; i++)
            {
                if(thiSinhs[i].TongDiem>=t)
                {
                    Console.WriteLine(thiSinhs[i].Sbd.PadRight(10) + thiSinhs[i].HoTen.PadRight(30)
                     + thiSinhs[i].DiaChi.PadRight(30) + Convert.ToString(thiSinhs[i].Toan).PadRight(15)
                     + Convert.ToString(thiSinhs[i].Ly).PadRight(15) + Convert.ToString(thiSinhs[i].Hoa).PadRight(15)
                     + Convert.ToString(thiSinhs[i].DiemUuTien).PadRight(15) + Convert.ToString(thiSinhs[i].TongDiem).PadRight(15));
                }
            }
        }

        //Hien thi cac sinh vien theo dia chi
        static void hienThiDiaChi(List<ThiSinhA> thiSinhs, string t)
        {
            Console.WriteLine("SBD".PadRight(10) + "Ho ten".PadRight(30) + "Dia chi".PadRight(30) 
                + "Diem toan".PadRight(15) + "Diem ly".PadRight(15) + "Diem hoa".PadRight(15) 
                + "Diem uu tien".PadRight(15) + "Tong diem".PadRight(15));
            for (int i = 0; i < thiSinhs.Count; i++)
            {
                if (thiSinhs[i].DiaChi.CompareTo(t) == 0)
                {
                    Console.WriteLine(thiSinhs[i].Sbd.PadRight(10) + thiSinhs[i].HoTen.PadRight(30)
                    + thiSinhs[i].DiaChi.PadRight(30) + Convert.ToString(thiSinhs[i].Toan).PadRight(15)
                    + Convert.ToString(thiSinhs[i].Ly).PadRight(15) + Convert.ToString(thiSinhs[i].Hoa).PadRight(15)
                    + Convert.ToString(thiSinhs[i].DiemUuTien).PadRight(15) + Convert.ToString(thiSinhs[i].TongDiem).PadRight(15));
                }
            }
        }

        //Tim kiem theo so bao danh
        static void hienThiSBD(List<ThiSinhA> thiSinhs, string t)
        {
            Console.WriteLine("SBD".PadRight(10) + "Ho ten".PadRight(30) + "Dia chi".PadRight(30) 
                + "Diem toan".PadRight(15) + "Diem ly".PadRight(15) + "Diem hoa".PadRight(15) 
                + "Diem uu tien".PadRight(15) + "Tong diem".PadRight(15));
            for (int i = 0; i < thiSinhs.Count; i++)
            {
                if (thiSinhs[i].Sbd.CompareTo(t) == 0)
                {
                    Console.WriteLine(thiSinhs[i].Sbd.PadRight(10) + thiSinhs[i].HoTen.PadRight(30)
                    + thiSinhs[i].DiaChi.PadRight(30) + Convert.ToString(thiSinhs[i].Toan).PadRight(15)
                    + Convert.ToString(thiSinhs[i].Ly).PadRight(15) + Convert.ToString(thiSinhs[i].Hoa).PadRight(15)
                    + Convert.ToString(thiSinhs[i].DiemUuTien).PadRight(15) + Convert.ToString(thiSinhs[i].TongDiem).PadRight(15));
                }
            }
        }
    }
}
