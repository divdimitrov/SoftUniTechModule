using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var participant = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(p => p.Trim()).ToList();
            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(s => s.Trim()).ToList();

            var input = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(i => i.Trim()).ToList();

            var result = new Dictionary<string, List<string>>();

            while (input[0] != "dawn")
            {
                var singer = input[0];
                var song = input[1];
                var award = input[2];

                if (participant.Contains(singer) && songs.Contains(song))
                {
                    if (!result.ContainsKey(singer))
                    {
                        result[singer] = new List<string>();
                    }
                    var awards = result[singer];

                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }
                input = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(i => i.Trim()).ToList();
            }
            if (result.Any())
            {
                foreach (var kvp in result
                                          .OrderByDescending(p => p.Value.Count)
                                          .ThenBy(p => p.Key))

                {
                    var singer = kvp.Key;
                    var awards = kvp.Value;
                    Console.WriteLine($"{singer}: {awards.Count} awards");

                    foreach (var award in awards.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}