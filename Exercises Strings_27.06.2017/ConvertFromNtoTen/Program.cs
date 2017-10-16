using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBaseNToBase10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            int @base = int.Parse(numbers[0]);
            string num = new string(numbers[1].Reverse().ToArray());

            BigInteger sum = new BigInteger();

            for (int power = 0; power < num.Length; power++)
            {
                int currentDigit = int.Parse(num[power].ToString());
                sum += currentDigit * BigInteger.Pow(@base, power);
            }

            Console.WriteLine(sum.ToString());
        }
    }
}