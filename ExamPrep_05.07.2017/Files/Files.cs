using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"([\w-]+\.[a-z]+);(\d+)";
                var regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                
                foreach (Match match in matches)
                {
                    string text = match.Groups[1].ToString();
                    int digit = int.Parse(match.Groups[2].Value);

                    list.Add(match.ToString());
                }
                Console.WriteLine(string.Join(",",list));
            }
            var lookingFor = Console.ReadLine().Split().ToList();

            Dictionary<string,int> dict = new Dictionary<string, int>();

            

            
           






        }
    }
}
