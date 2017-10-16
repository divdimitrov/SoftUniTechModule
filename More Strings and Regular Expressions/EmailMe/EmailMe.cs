using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
        
            var firstPart = input.IndexOf('@');

            string firstChars = input.Substring(0, firstPart);
            string lastChar = input.Split('@').Last();

            int result = firstChars.ToCharArray().Select(x => (int)x).Sum();
            var result2 = lastChar.ToCharArray().Select(x => (int)x).Sum();

            if (result - result2 >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
