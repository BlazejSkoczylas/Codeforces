using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace WatermelonC
{
    class Program
    {
        private static void erase(int[] array, int groupQuantity)
        {
            int index = Array.FindIndex(array, i => i == 1);
            if (index != -1 && groupQuantity > 0)
            {
                array[index] = 0;
                groupQuantity--;
                erase(array, groupQuantity);
            }
        }

        static void Main(string[] args)
        {
            string strNumber = Console.ReadLine();
            string strGroups = Console.ReadLine();
            int numberOfGroups = 0;
            int.TryParse(strNumber, out numberOfGroups);
            int[] arrayIntGroups = new int[numberOfGroups];
            string[] arrayStrGroups = strGroups.Split(' ');
            if (numberOfGroups > 0 && numberOfGroups < 1000001)
            {
                for (int i = 0; i < numberOfGroups; i++)
                {
                    int n = 0;
                    int.TryParse(arrayStrGroups[i], out n);
                    arrayIntGroups[i] = n;
                }

                Array.Sort(arrayIntGroups);

                int w = 0;

                if (Array.Find(arrayIntGroups, i => i > 1) > 0)
                {
                    for (int j = 0; j < numberOfGroups; j++)
                    {
                        int index = -1;
                        switch (arrayIntGroups[j])
                        {
                            case 4:
                                arrayIntGroups[j] = 0;
                                w += 1;
                                break;
                            case 3:
                                arrayIntGroups[j] = 0;
                                erase(arrayIntGroups, 1);
                                w += 1;
                                break;
                            case 2:
                                arrayIntGroups[j] = 0;
                                index = Array.FindIndex(arrayIntGroups, i => i == 2);
                                if (index != -1)
                                {
                                    arrayIntGroups[index] = 0;
                                }
                                else
                                {
                                    erase(arrayIntGroups, 2);
                                }

                                w += 1;
                                break;
                            case 1:
                                arrayIntGroups[j] = 0;
                                index = Array.FindIndex(arrayIntGroups, i => i == 3);
                                if (index != -1)
                                {
                                    arrayIntGroups[index] = 0;
                                }
                                else if (Array.FindIndex(arrayIntGroups, i => i == 2) != -1)
                                {
                                    index = Array.FindIndex(arrayIntGroups, i => i == 2);
                                    arrayIntGroups[index] = 0;
                                    erase(arrayIntGroups, 1);
                                }
                                else
                                {
                                    erase(arrayIntGroups, 3);
                                }

                                w += 1;
                                break;
                        }
                    }
                }
                else
                {
                    if (arrayIntGroups.Length % 4 > 0)
                        w = arrayIntGroups.Length / 4 + 1;
                    else
                        w = arrayIntGroups.Length / 4;
                }
                Console.WriteLine(w);
            }
        }
    }
}
