using System;
using System.Numerics;
namespace WatermelonC
{  
    class Program
    {
        private static void writeSolution(string[] table)
        {
            Console.WriteLine("YES");
            foreach (var s in table)
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            string[]  table = new string[n];
            bool isPair = false;

            for (int i = 0; i < n; i++)
            {
                table[i] = Console.ReadLine();
                if (table[i].Contains("OO|OO") && !isPair)
                {
                    table[i] = "++|OO";
                    isPair = true;
                }
                else if (table[i].Contains("OO") && !isPair)
                {
                    table[i] = table[i].Replace("OO", "++");
                    isPair = true;
                }
            }

            if (isPair)
                writeSolution(table);
            else
                Console.WriteLine("NO");
            
        }
    }
}
