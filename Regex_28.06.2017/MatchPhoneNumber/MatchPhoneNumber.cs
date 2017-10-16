using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string regex = @"\+[359]*(\s|-)[2](\1)\d{3}\1\b\d{4}\b";

            string input = Console.ReadLine();

            var phoneMatches = Regex.Matches(input, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));


        }
    }
}
