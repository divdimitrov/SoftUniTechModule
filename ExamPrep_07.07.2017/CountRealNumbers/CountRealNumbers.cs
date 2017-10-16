using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var dict = new SortedDictionary<double, int>();
            foreach (var item in input)
            {
                double paresedItem = double.Parse(item);
                if (!dict.ContainsKey(paresedItem))
                {
                    dict[paresedItem] = 0;
                }
                dict[paresedItem] ++;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }

                
        }
    }
}
