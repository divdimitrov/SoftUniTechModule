using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hideout
{
    class Hideout
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var list = Console.ReadLine().Split().ToList();
            var hint = list[0];
            var repeat = list[1];

            string pattern = $"[{{{hint}}}]{{{repeat}}}";

            Regex regex = new Regex(pattern);

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches == re)
            {

            }

        }
    }
}
