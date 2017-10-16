using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace EmailStatistics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();

                string pattern = @"\b(?<username>[A-Za-z]+[A-Za-z]{4,})\@(?<domain>[a-z]+[a-z]{2,}(\.com|\.bg|\.org))\b";

                Regex regex = new Regex(pattern);

                MatchCollection emails = regex.Matches(email);

                foreach (Match item in emails)
                {
                    var username = item.Groups["username"].Value;
                    var domain = item.Groups["domain"].Value;

                    if (!result.ContainsKey(domain))
                    {
                        HashSet<string> usernames = new HashSet<string>();
                        usernames.Add(username);
                        result.Add(domain, usernames);
                    }
                    result[domain].Add(username);
                }
            }

            foreach (var domain in result.Keys.OrderByDescending(k => result[k].Count))
            {
                Console.WriteLine($"{domain}:");
                foreach (var username in result[domain])
                {
                    Console.WriteLine($"### {username}");
                }
            }

        }
    }
}