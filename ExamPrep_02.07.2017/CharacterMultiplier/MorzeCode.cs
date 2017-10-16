using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentence = Console.ReadLine();

            var cleaned = Regex.Replace(sentence, $@"\b{word}", new string('*', word.Length), RegexOptions.IgnoreCase);

            Console.WriteLine(cleaned);
        }
    }
}