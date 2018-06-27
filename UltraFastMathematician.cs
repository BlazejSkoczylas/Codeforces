using System;
using System.Numerics;
namespace WatermelonC
{
    class Program
    {       
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                    Console.Write("0");
                else
                    Console.Write("1");
            }
        }
    }
}
