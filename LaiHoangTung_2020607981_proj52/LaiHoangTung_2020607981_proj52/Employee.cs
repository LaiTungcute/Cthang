using System;
using System.Collections.Generic;
using System.Text;

namespace LaiHoangTung_2020607981_proj52
{
    class Employee
    {
        private string id;
        private string name;
        private int age;
        private int workingdays;
        private double salary;
        private const int PRICE = 50;

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Workingdays { get { return workingdays; } set { workingdays = value; } }
        public double getSalary ()
        {
            return (double) workingdays * PRICE;
        }

        public void Input ()
        {
            Console.Write("Nhap ma nhan vien: ");
            id = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ngay cong: ");
            workingdays = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Ma nhan vien: " + id);
            Console.WriteLine("Ten nhan vien: " + name);
            Console.WriteLine("Tuoi nhan vien: " + age);
            Console.WriteLine("So ngay cong: " + workingdays);
            Console.WriteLine("Luong: " + getSalary());
        }
    }
}
