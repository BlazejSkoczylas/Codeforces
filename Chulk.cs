using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace WatermelonC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    Console.Write("I hate ");
                else
                {
                    Console.Write("I love ");
                }
                if (i != n)
                {
                    Console.Write("that ");
                }
                else
                {
                    Console.Write("it");
                }
            }
        }
    }
}
