using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace OnlyLetters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = $@"(?<digits>\d+)(?<letter>[a-zA-Z])";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                text = text.Replace(item.Groups["digits"].ToString(), item.Groups["letter"].ToString());
            }
            Console.WriteLine(text);
        }
    }
}