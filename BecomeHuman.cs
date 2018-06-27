using System;
using System.Numerics;
namespace WatermelonC
{
    class Program
    {
        private static BigInteger power(BigInteger a, BigInteger b)
        {
            return BigInteger.Pow(a, (int)b);
        }

        static void Main(string[] args)
        {
            BigInteger x = 0, y = 0, w1 = 0, w2 = 0;
            string[] digits = new string[2];
            digits = Console.ReadLine().Split(' ');
            BigInteger.TryParse(digits[0], out x);
            BigInteger.TryParse(digits[1], out y);
            if (x == y)
                Console.WriteLine("=");
            else if (x < 100 && y < 100)
            {
                if (x > y)
                {
                    w1 = power(x, y);
                    w2 = y;
                    for (int i = 1; i <= x; i++)
                    {
                        w2 *= y;
                        if (w2 > w1)
                        {
                            Console.WriteLine("<");
                            return;
                        }
                        else if (i == x)
                            Console.WriteLine(">");
                    }
                }
                else if (x < y)
                {
                    w1 = power(y, x);
                    w2 = x;
                    for (int i = 1; i <= y; i++)
                    {
                        w2 *= x;
                        if (w2 > w1)
                        {
                            Console.WriteLine(">");
                            return;
                        }
                        else if (i == y)
                            Console.WriteLine("<");
                    }
                }
            }
            else if (x > y)
                Console.WriteLine("<");
            else
                Console.WriteLine(">");
        }
    }
}
