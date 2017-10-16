using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexa
{
    class MatchHexa
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[0-9A-F]+\b";

            var input = Console.ReadLine();
            var numbers = Regex.Matches(input, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",numbers));

           
        }
    }
}
