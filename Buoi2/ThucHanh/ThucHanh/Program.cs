using System;

namespace ThucHanh
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(" ");
            string chuoichan = string.Empty;
            string chuoile = string.Empty;
            for(int i=0;i<arr.Length;i++)
            {
                int temp = int.Parse(arr[i]);
                if (temp % 2 == 0) chuoichan += temp + " ";
                else chuoile += temp + " ";
            }
            Console.WriteLine(chuoichan);
            Console.WriteLine(chuoile);
        }
    }
}
