﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = 0;
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    numCount++;

                }
                catch (OverflowException)
                {
                    break;
                }
                catch (FormatException)
                {
                    break;
                }
            }

            Console.WriteLine(numCount);
        }
    }
}
