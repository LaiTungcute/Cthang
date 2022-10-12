using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    class Person
    {
        private string id;
        private string name;
        private int age;
        private string email;
        private string address;
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Address { get { return address; } set { address = value; } }

        public void checkAge ()
        {
            if (age >= 18) Console.WriteLine("Bạn đã đủ tuổi bầu cử".PadRight(20));
            else Console.WriteLine("Bạn còn nhỏ".PadRight(20));
        }

        public void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();
        }

        public void Output()
        {
            Console.Write(id.PadRight(10) + name.PadRight(20) + Convert.ToString(age).PadRight(10) + email.PadRight(40) + address.PadRight(40));
            checkAge();
        }
    }
}
