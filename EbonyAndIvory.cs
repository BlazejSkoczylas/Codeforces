using System;
using System.Numerics;
namespace WatermelonC
{  
    class Program
    {
        private static int NWD(int a, int b)
        { 
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int firstGun, secondGun, shield;
            int.TryParse(input[0], out firstGun);
            int.TryParse(input[1], out secondGun);
            int.TryParse(input[2], out shield);
            bool flag = false;

            for (int i = 0; i <= 10000; i++)
            {
                if ((shield - i * secondGun) % firstGun == 0 && (shield - i * secondGun) / firstGun < 0)   
                    flag = true;
                else
                    flag = false;
            }
            if (flag)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
