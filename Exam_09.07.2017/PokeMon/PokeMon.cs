using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int factor = int.Parse(Console.ReadLine());
            int temp = 0;
            int count = 0;

            var percent = power / 2.0;

            while (power >= distance)
            {
                temp = power - distance;
                

                if (temp == percent && factor !=0)
                {
                    
                    temp = temp / factor;
                }
                power = temp;
                count++;
            }


            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
