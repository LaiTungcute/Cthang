using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //string[] arr = s.Split(" ");
            int a = 0;
            for(int i = 0;i<s.Length/2;i++)
            {
                if(s[i] == s[s.Length-1 - i])
                {
                    a++;
                }
            }
            if (a == s.Length / 2 || a==(s.Length / 2) - 1)
            {
                Console.WriteLine("Chuoi doi xung");
            }
            else
            {
                Console.WriteLine("Chuoi khong doi xung");
            }
        }
    }
}
