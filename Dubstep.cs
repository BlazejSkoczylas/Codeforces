using System;
using System.Numerics;
namespace WatermelonC
{  
    class Program
    {
        static void Main(string[] args)
        {
            string dubstep = Console.ReadLine();
            string original = "";
            original = dubstep.Replace("WUB", " ");
            for (int i = 0; i < original.Length - 1; i++)
            {
                if (original[i] == ' ' && original[i + 1] == ' ')
                    original = original.Remove(i, 1);
            }

            if (original[0] == ' ')
                original = original.Remove(0, 1);           
            if (original[original.Length - 1] == ' ')
                original = original.Remove(original.Length - 1);
           
            Console.WriteLine(original);
        }
    }
}
