﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if (endNum - startNum < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = startNum; i <= endNum - 4; i++)
            {
                for (int j = i + 1; j <= endNum - 3; j++)
                {
                    for (int k = j + 1; k <= endNum - 2; k++)
                    {
                        for (int m = k + 1; m <= endNum - 1; m++)
                        {
                            for (int n = m + 1; n <= endNum; n++)
                            {
                                Console.WriteLine($"{i} {j} {k} {m} {n}");
                            }
                        }
                    }
                }
            }
        }
    }
}
