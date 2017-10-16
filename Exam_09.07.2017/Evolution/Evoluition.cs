using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
   
    class Evoluition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input !="wubbalubbadubdub")
            {
                var tokens = input.Split("-, <".ToCharArray()).ToList();

                var pokemonName = tokens[0];
                var pokemonEvo = tokens[1];
                var pokemonIndex = int.Parse(tokens[2]);

                var list = new List<string>();

                foreach (var item in input)
                {
                    list.Add(pokemonName);
                    list.Add(pokemonEvo);
                }

            }

           

            
        }
    }
}
