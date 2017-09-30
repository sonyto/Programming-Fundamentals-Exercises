using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());

            int PeshoHealth = 100;
            int GoshoHealth = 100;
            int turn = 0;

            while (PeshoHealth >0 && GoshoHealth >0)
            {
                turn++;
                if (turn % 2 != 0)
                {
                    GoshoHealth -= PeshoDamage;
                    if (GoshoHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                }
                else 
                {
                    PeshoHealth -= GoshoDamage;
                    if (PeshoHealth < 1) 
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                }
                if (turn %3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
            }
            
            
        }
    }
}
