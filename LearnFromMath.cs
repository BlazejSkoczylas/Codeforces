using System;
using System.Numerics;
namespace WatermelonC
{
    class Program
    {
        private static bool isComposite (int n)
        {
            if (n != 2 && n != 5 && n != 3 && n != 11 && n != 7 && n != 13)
            {
                if (n < 121)
                {
                    if (n % 2 == 0 || n % 5 == 0 || n % 3 == 0 || n % 7 == 0)
                        return true;
                }
                else if (n % 2 == 0 || n % 5 == 0 || n % 3 == 0 || n % 11 == 0 || n % 7 == 0 || n % 13 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static void writeSolution (int x, int y)
        {
            while (!(isComposite(x) && isComposite(y)))
            {
                    x++;
                    y--;
            }
            Console.WriteLine(x + " " + y);
        }

        static void Main(string[] args)
        {
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            if (n >= 12 && n <= 10000000)
            {
                int x = n / 2 + n % 2;
                int y = n / 2;
                writeSolution(x, y);
            }
        }
    }
}
