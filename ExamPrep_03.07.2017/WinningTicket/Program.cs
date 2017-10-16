using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace WinningTicket
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(p => p.Trim()).ToList();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftSide = ticket.Substring(0, ticket.Length / 2);
                    string rightSide = ticket.Substring(ticket.Length / 2);

                    string pattern = @"(?<dollars>\${6,10})|(?<at>\@{6,10})|(?<sharp>\#{6,10})|(?<roof>\^{6,10})";

                    Regex regex = new Regex(pattern);

                    Match matchLeft = regex.Match(leftSide);
                    Match matchRight = regex.Match(rightSide);

                    if (matchLeft.Success && matchRight.Success)
                    {

                        if (matchLeft.ToString().ToCharArray()[0] == matchRight.ToString().ToCharArray()[0])
                        {
                            if (matchRight.Length == matchLeft.Length)
                            {
                                string winTicket = ticket;
                                int countSymbols = matchRight.Length;
                                char simbol = matchLeft.ToString().ToCharArray()[0];

                                if (matchLeft.Length == 10 && matchRight.Length == 10)
                                {
                                    Console.WriteLine($@"ticket ""{ticket}"" - {countSymbols}{simbol} Jackpot!");
                                }
                                else
                                {
                                    Console.WriteLine($@"ticket ""{ticket}"" - {countSymbols}{simbol}");
                                }
                            }
                            else if (matchRight.Length != matchLeft.Length)
                            {
                                string winTicket = ticket;
                                int countSymbols = Math.Min(matchLeft.Length, matchRight.Length);
                                char simbol = matchLeft.ToString().ToCharArray()[0];

                                Console.WriteLine($@"ticket ""{ticket}"" - {countSymbols}{simbol}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($@"ticket ""{ticket}"" - no match");
                    }
                }
            }
        }
    }
}