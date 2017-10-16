using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            List<string> list = new List<string>();
            var list2 = new List<char>();

            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value.ToUpper();
                int digit = int.Parse(match.Groups[2].Value);
                
                for (int i = 0; i < digit; i++)
                {
                    list.Add(text);
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (!list2.Contains(text[i]))
                    {
                        list2.Add(text[i]);
                    }
                }
            }
            
            Console.WriteLine("Unique symbols used: {0}", list2.Distinct().Count());
            Console.WriteLine(string.Join("",list));
           
            
        }
    }
}
