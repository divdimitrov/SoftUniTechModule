using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesbyKeyword
{
    class ExtractSentencesbyKeyword
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = $"[^!?.]*((\b{word}\b\\W)|(\\W\\b{word}\\b\\W))[^!?.]*";

            var regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }


        }
    }
}
