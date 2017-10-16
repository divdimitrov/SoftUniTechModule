using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censorship
{
    class Censorship
    {
        static void Main(string[] args)
        {
            //Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            string censor = Console.ReadLine();
            var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            var sentense = Console.ReadLine();

           sentense = sentense.Replace(censor, new string('*', censor.Length));


            Console.WriteLine(sentense);

        }
    }
}
