using System;
using System.Numerics;
namespace WatermelonC
{  
    class Program
    {
        private static int printSolution(int[,] time)
        {
            int count = 1;
            int cash = 1;
            for (int i = 0; i < time.Length/2-1; i++)
            {
                if (time[i, 1] == time[i + 1, 1])
                {
                    if (time[i, 0] == time[i + 1, 0])
                        count++;
                }
                else if (count > cash)
                {
                    cash = count;
                    count = 1;
                }
                else
                    count = 1;
            }

            if (count > cash)
                cash = count;

            return cash;
        }

        static void Main(string[] args)
        {
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            int[,] time = new int[n,2];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 2; j++)
                {
                    int clock;
                    int.TryParse(input[j], out clock);
                    time[i, j] = clock;
                }
            }
            Console.WriteLine(printSolution(time));
        }
    }
}
