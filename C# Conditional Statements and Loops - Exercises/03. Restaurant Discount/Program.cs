using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int GroupSize = int.Parse(Console.ReadLine());
            var Package = Console.ReadLine();

            var TotalPrice = 0.0;
            string Hall;

            if (GroupSize <= 50)
            {
                Hall = "Small Hall";
                switch (Package)
                {
                    case "Normal":; TotalPrice = (2500 + 500)*0.95;break;
                    case "Gold":; TotalPrice = (2500 + 750)*0.90; break;
                    case "Platinum":; TotalPrice = (2500 + 1000)*0.85; break;
                }
                Console.WriteLine($"We can offer you the {Hall}");
                Console.WriteLine($"The price per person is {TotalPrice/ GroupSize:f2}$");
            }
            else if (GroupSize > 50 && GroupSize <= 100) 
            {
                Hall = "Terrace";
                switch (Package)
                {
                    case "Normal":; TotalPrice = (5000 + 500)*0.95; break;
                    case "Gold":; TotalPrice = (5000 + 750)*0.90; break;
                    case "Platinum":; TotalPrice = (5000 + 1000)*0.85; break;
                }
                Console.WriteLine($"We can offer you the {Hall}");
                Console.WriteLine($"The price per person is {TotalPrice / GroupSize:f2}$");
            }
            else if (GroupSize>100 && GroupSize<=120)
            {
                Hall = "Great Hall";
                switch (Package)
                {
                    case "Normal":; TotalPrice = (7500 + 500) * 0.95; break;
                    case "Gold":; TotalPrice = (7500 + 750) * 0.90; break;
                    case "Platinum":; TotalPrice = (7500 + 1000) * 0.85; break;
                }
                Console.WriteLine($"We can offer you the {Hall}");
                Console.WriteLine($"The price per person is {TotalPrice / GroupSize:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
