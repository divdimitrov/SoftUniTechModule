using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace Regexmon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternDidimon = @"[^a-zA-Z-]+";
            string patternBojomon = @"[a-zA-Z]+-[a-zA-Z]+";

            Regex regexDidimon = new Regex(patternDidimon);
            Match didimon = regexDidimon.Match(input);

            Regex regexBojomon = new Regex(patternBojomon);
            Match bojomon = regexBojomon.Match(input);

            while (true)
            {
                if (didimon.Success)
                {
                    Console.WriteLine(didimon);
                    input = input.Remove(0, didimon.Length);
                }
                else
                {
                    break;
                }

                if (bojomon.Success)
                {
                    Console.WriteLine(bojomon);
                    input = input.Remove(0, bojomon.Length-1);
                }
                else
                {
                    break;
                }

                regexDidimon = new Regex(patternDidimon);
                didimon = regexDidimon.Match(input);

                regexBojomon = new Regex(patternBojomon);
                bojomon = regexBojomon.Match(input);
            }
        }
    }
}