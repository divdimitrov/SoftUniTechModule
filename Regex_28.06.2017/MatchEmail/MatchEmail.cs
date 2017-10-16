using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchEmail
{
    class MatchEmail
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"(\s|^)[A-Za-z0-9]+([-._][a-z0-9A-Z]*)?@([a-z]+\-?[a-z]+\.)?([a-z]+\-?[a-z]+\.[a-z]+)";

            var regex = new Regex(patern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }


        }
    }
}
