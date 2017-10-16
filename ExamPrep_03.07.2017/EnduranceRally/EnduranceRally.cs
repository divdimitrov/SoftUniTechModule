using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine()
                  .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)

                  .ToArray();

            var track = Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            var checkpoint = Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                    .ToArray();


            foreach (var driver in drivers)
            {

                double fuel = driver.First();


                //obikalqne vyrhu pistata

                for (int i = 0; i < track.Length; i++)
                {

                    var currentZoneFuel = track[i];

                    if (checkpoint.Contains(i))
                    {
                        //+
                        fuel += currentZoneFuel;

                    }
                    else
                    {
                        //-
                        fuel -= currentZoneFuel;
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}