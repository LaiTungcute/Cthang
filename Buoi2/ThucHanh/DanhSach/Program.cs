using System;
using System.Collections.Generic;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> a = new List<float>(5);
            for(int i=0;i<5;i++)
            {
                a.Add(float.Parse(Console.ReadLine()));
            }
            a.Sort();
            for(int i=0;i<5;i++)
            {
                if(a.IndexOf(i) <0)
                {
                    a.Remove(a.IndexOf(i));
                }
            }
            a.Insert(3, 4.4f);
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
