using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangableWords
{
    class ExchangableWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var list1 = input[0].Distinct().ToList();
            var list2 = input[1].Distinct().ToList();

           
            if (list1.Count == list2.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
