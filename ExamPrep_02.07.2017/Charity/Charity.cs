using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    class Charity
    {
        static void Main(string[] args)
        {
           
            int daysOfMaraton = int.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            int LapsPerRunner = int.Parse(Console.ReadLine());
            long TrackLength = long.Parse(Console.ReadLine());
            int CapacityOfTrack = int.Parse(Console.ReadLine());
            double MoneyDonatedPerKM = double.Parse(Console.ReadLine());

            long maxRunners = CapacityOfTrack * daysOfMaraton;
            if (maxRunners > numberOfRunners)
            {
                maxRunners = numberOfRunners;
            }
            long totalMeters = maxRunners * LapsPerRunner * TrackLength;
            long totalKM = totalMeters / 1000;
            double totalmoney = totalKM * MoneyDonatedPerKM;

            Console.WriteLine($"Money raised: {totalmoney:F2}");

           


        }
    }
}
