using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int wordsToskip = int.Parse(input[0]);
            int wordsToTake = int.Parse(input[1]);

            string text = Console.ReadLine();

            string pattern = $@"\|<(\w{{{wordsToskip}}})(\w{{0,{wordsToTake}}})";
           
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            var list = new List<string>();
            foreach (Match item in matches)
            {
                list.Add(item.Groups[2].Value);
               
            }
            Console.WriteLine(string.Join(", ",list));

        }
    }
}
