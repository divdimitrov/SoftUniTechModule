using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurances
{
    class OddOccurances
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().ToList();
            var dict = new Dictionary<string, int>();
            var list = new List<string>();

            foreach (var word in input)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }
                dict[word]++;
            }
            foreach (var item in dict)
            {
                string words = item.Key;
                int occurance = item.Value;
                if (occurance % 2 == 1)
                {
                    list.Add(words);
                    
                }
                
            }
            Console.WriteLine(string.Join(", ", list));

        }
    }
}
