using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var list = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    list.Add(input[i]);
                }
            }

            var average = list.Average();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= average)
                {
                    list[i] -= 1;
                }
                else
                {
                    list[i] += 1;
                }
            }


            Console.WriteLine(string.Join(" ",list));
            
        }
    }
}
