using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;


namespace SinoWalking
{
    class Program
    {


        static void Main(string[] args)
        {
            var format = "HH:mm:ss";

            var startTime = DateTime.ParseExact(Console.ReadLine()
                , format,
                CultureInfo.InvariantCulture);

            var steps = int.Parse(Console.ReadLine());
            var stepPerSec = int.Parse(Console.ReadLine());

            long initialSeconds = startTime.Hour * 60 * 60
                                  + startTime.Minute * 60
                                  + startTime.Second;

            ulong secondToAdd = (ulong)steps * (ulong)stepPerSec;
            ulong totalSeconds = (ulong)initialSeconds + secondToAdd;

            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHour = totalMinutes / 60;
            var hours = totalHour % 24;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }


    }
}