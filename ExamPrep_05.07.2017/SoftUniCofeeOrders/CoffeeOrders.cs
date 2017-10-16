using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCofeeOrders
{
    class CoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal grandTotal = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal totalPrice = (daysInMonth * capsuleCount) * pricePerCapsule;
                grandTotal += totalPrice;

                Console.WriteLine($"The price for the coffee is: ${totalPrice:F2}");

            }
            Console.WriteLine($"Total: ${grandTotal:F2}");
        }
    }
}
