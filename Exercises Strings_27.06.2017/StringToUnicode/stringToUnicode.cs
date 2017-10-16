using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToUnicode
{
    class stringToUnicode
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = GetUnicodeString(input);

            Console.WriteLine(result);
            
        }
        public static string GetUnicodeString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            return sb.ToString();
        }
    }
}
