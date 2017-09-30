using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            var studiPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;
            var totalStudioPrice = studiPrice*nights;

            if (text == "May" || text == "October")
            {
                studiPrice = 50.0; doublePrice = 65.0; suitePrice = 75.0;
                totalStudioPrice = studiPrice * nights;
                if (nights > 7 )
                { studiPrice = 50 *0.95; totalStudioPrice = studiPrice * nights; }
             }

             if (text == "June" || text == "September")
            {

                studiPrice = 60; doublePrice = 72; suitePrice = 82;
                totalStudioPrice = studiPrice * nights;
                if (nights > 14)
                { doublePrice = 72*0.90; }
            }

             if (text == "July" || text == "August" || text == "December")
            {
                studiPrice = 68; doublePrice = 77; suitePrice = 89;
                totalStudioPrice = studiPrice * nights;
                if (nights > 14)
                { suitePrice = 89 * 0.85; }
            }

            if (nights > 7 && text == "September")
            {
                studiPrice = 60;
                totalStudioPrice = studiPrice * (nights - 1);

            }

            if (nights > 7 && text == "October")
            {
                studiPrice = 50 * 0.95;
                totalStudioPrice = studiPrice * (nights - 1);
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {(doublePrice * nights):f2} lv.");
            Console.WriteLine($"Suite: {(suitePrice * nights):f2} lv.");
        }
    }
}
