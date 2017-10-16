using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var resultDict = new Dictionary<string, int>();

            while (input != "end")
            {
                var tokens = input.Split().ToList();

                var firstElement = tokens[0];
                var LastElement = tokens[tokens.Count - 1];

                int number = 0;
                if (int.TryParse(LastElement,out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(LastElement))
                    {
                        var referValue = resultDict[LastElement];
                        resultDict[firstElement] = referValue;
                    }
                    
                }


                input = Console.ReadLine();
            }
            foreach (var item in resultDict)
            {
                var name = item.Key;
                var num = item.Value;
                Console.WriteLine($"{name} === {num}");
            }


        }
    }
}
