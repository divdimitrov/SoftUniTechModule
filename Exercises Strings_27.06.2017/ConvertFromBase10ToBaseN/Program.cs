using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBase10ToBaseN
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<BigInteger> input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            BigInteger toConvert = input[0];
            BigInteger num = input[1];


            string asd = "";
            BigInteger currentResult = 0;


            while (num > 0)
            {
                currentResult = num % toConvert;

                asd += currentResult;
                num = num / toConvert;
            }

            var result = string.Empty;

            for (int i = asd.Length - 1; i >= 0; i--)
            {
                result += asd[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}