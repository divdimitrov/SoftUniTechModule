using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace KarateStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    i++;
                    while (power > 0 && i < input.Length)
                    {
                        if (input[i] == '>')
                        {
                            break;
                        }
                        power--;
                        input.Remove(i, 1);
                    }
                    i--;
                }

            }
            Console.WriteLine(input);
        }
    }
}