using System;
using System.Numerics;
namespace WatermelonC
{  
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, officers = 0, untreated = 0;
            int.TryParse(Console.ReadLine(), out n);
            string[] array = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int l = 0;
                int.TryParse(array[i], out l);
                if (l > 0)
                    officers += l;
                else if (l < 0)
                    if (officers > 0)
                        officers--;
                    else
                        untreated++;
            }
            Console.WriteLine(untreated);
        }
    }
}
