using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dictionary = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = 0;
                }
                dictionary[letter]++;
            }
            foreach (var item in dictionary)
            {
                char letter = item.Key;
                int num = item.Value;
                Console.WriteLine($"{letter} -> {num}");
            }

        }
    }
}
