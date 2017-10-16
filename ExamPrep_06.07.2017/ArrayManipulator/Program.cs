using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var tokens = line.Split();

                var command = tokens.First();
                if (command == "exchange")
                {
                    var index = int.Parse(tokens[1]);
                    
                }
            }

        }
    }
}
