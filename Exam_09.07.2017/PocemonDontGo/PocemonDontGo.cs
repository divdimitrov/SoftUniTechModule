using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputIntegers = Console.ReadLine().Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var sum = 0;
            var checkNum = 0;
            while (inputIntegers.Count >= 1)
            {
                
                var numToIndex = int.Parse(Console.ReadLine());

                if (inputIntegers.Count == 1)
                {
                    sum += inputIntegers[0];
                    break;
                }

                if (numToIndex < 0)
                {
                    sum += inputIntegers[0];
                    checkNum = inputIntegers[0];
                    inputIntegers[0] = inputIntegers[inputIntegers.Count - 1];

                }
                else if (numToIndex >= inputIntegers.Count)
                {
                    sum += inputIntegers[inputIntegers.Count - 1];
                    checkNum = inputIntegers[inputIntegers.Count - 1];
                    inputIntegers[inputIntegers.Count - 1] = inputIntegers[0];

                }
                else if (numToIndex >= 0 || numToIndex <= inputIntegers.Count - 1)
                {
                    sum += inputIntegers[numToIndex];
                    checkNum = inputIntegers[numToIndex];
                    inputIntegers.RemoveAt(numToIndex);

                }
                for (int i = 0; i < inputIntegers.Count; i++)
                {
                    if (inputIntegers[i] <= checkNum)
                    {
                        inputIntegers[i] += checkNum;
                    }
                    else
                    {
                        inputIntegers[i] -= checkNum;
                    }
                }

            }
            Console.WriteLine(sum);
        }
    }
}

