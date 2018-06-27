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
            //string[,] matrix = new string[5,5];
            string[] elements = new string[5];
            int x = 0, y = 0;

            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                elements = line.Split(' ');

                for (int j = 0; j < 5; j++)
                {
                    //matrix[i, j] = elements[j];
                    if (elements[j] == "1")
                    {
                        if (j >= 2)
                            x = j - 2;
                        else
                            x = 2 - j;
                        if (i >= 2)
                            y = i - 2;
                        else
                            y = 2 - i;
                    }
                }
            }
            Console.WriteLine(x + y);
        }
    }
}
