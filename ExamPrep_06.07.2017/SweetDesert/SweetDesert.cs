using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDesert
{
    class SweetDesert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal egsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPricePerKilo = decimal.Parse(Console.ReadLine());

            decimal numberOfSets = Math.Ceiling((decimal)numberOfGuests / 6);

            decimal totalCost = numberOfSets * (2 * bananaPrice) + numberOfSets * (4 * egsPrice) + numberOfSets * ((decimal)0.2 * berriesPricePerKilo);
            if (totalCost <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.",Math.Abs(totalCost - cash));
            }

            
           
        }
    }
}
