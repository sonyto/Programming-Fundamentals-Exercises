using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            var price = 0.00;

            switch (profession)
            {
                case "Athlete":price = 0.70; Console.WriteLine($"The { profession} has to pay {quantity*price:f2}."); break;
                case "Businessman":price = 1.00; Console.WriteLine($"The { profession} has to pay {quantity * price:f2}."); break;
                case "Businesswoman": price = 1.00; Console.WriteLine($"The { profession} has to pay {quantity * price:f2}."); break;
                case "SoftUni Student": price = 1.70; Console.WriteLine($"The { profession} has to pay {quantity * price:f2}."); break;
                default: price = 1.20; Console.WriteLine($"The { profession} has to pay {quantity * price:f2}."); break;
            }
        }
    }
}
