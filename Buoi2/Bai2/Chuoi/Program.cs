using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            //a
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine();
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }

            //b
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine();
            s.Trim();
            for(int i=0;i<s.Length-1;i++)
            {
                if(s[i]==' ' && s[i+1]==' ')
                {
                    Console.WriteLine(s[i]);
                }
                else
                {
                    Console.Write(s[i]);
                }
            }

            //c
            //Console.Write("Nhap chuoi: ");
            //s = Console.ReadLine();
            //for (int i=0;i<s.Length;i++)
            //{
            //    int t1 = 0;

            //}
        }
    }
}
