using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList().OrderBy(x => x);

            Console.WriteLine(string.Join(", ",input));

            
        }
    }
}
