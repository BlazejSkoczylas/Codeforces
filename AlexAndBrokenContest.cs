using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.ComponentModel;

namespace WatermelonC
{
    public enum Name : int
    {
        [Description("Danil")] Danil,
        [Description("Olya")] Olya,
        [Description("Slava")] Slava,
        [Description("Ann")] Ann,
        [Description("Nikita")] Nikita,
    }

    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int lucky = 0;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '4' || numbers[i] == '7')
                    lucky++;
            }

            if (lucky == 4 || lucky == 7)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
