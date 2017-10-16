using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new SortedDictionary<string, long>();


            while (input != "Over")
            {
                var command = input.Split().ToList();

                var firstElement = command[0];
                var lastElement = command[command.Count-1];

                long num = 0;
                if (long.TryParse(firstElement,out num))
                {
                    dict[lastElement] = num;
                }
                else if (long.TryParse(lastElement,out num))
                {
                    dict[firstElement] = num;
                }
                
                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                var num = item.Value;
                var name = item.Key;

                Console.WriteLine($"{name} -> {num}");
            }
        }
    }
}
