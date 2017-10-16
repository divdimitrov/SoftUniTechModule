using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Problem1
{
    static void Main()
    {
        List<string> strings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] splitCommands = command.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (splitCommands[0])
            {
                case "reverse": Reverse(strings, int.Parse(splitCommands[2]), int.Parse(splitCommands[4])); break;
                case "sort": Sort(strings, int.Parse(splitCommands[2]), int.Parse(splitCommands[4])); break;
                case "rollLeft": RollLeft(strings, int.Parse(splitCommands[1])); break;
                case "rollRight": RollRight(strings, int.Parse(splitCommands[1])); break;
                default:
                    break;
            }
            command = Console.ReadLine();
        }
        Console.Write("[{0}]", string.Join(", ", strings));
    }

    private static void RollRight(List<string> strings, int p)
    {
        if (p < 0)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        int count = strings.Count;
        int realRoll = p % count;
        for (int i = 0; i < realRoll; i++)
        {
            strings.Insert(0, strings[count - 1]);
            strings.RemoveAt(count);
        }
    }

    private static void RollLeft(List<string> strings, int p)
    {
        if (p < 0)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        int realRoll = p % strings.Count;
        for (int i = 0; i < realRoll; i++)
        {
            strings.Add(strings[0]);
            strings.RemoveAt(0);
        }
    }

    private static void Sort(List<string> strings, int p1, int p2)
    {
        int count = strings.Count;
        if (p1 < 0 || p2 < 0 || p1 >= count || (long)p1 + (long)p2 - 1 >= count)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        strings.Sort(p1, p2, StringComparer.InvariantCulture);
    }

    private static void Reverse(List<string> strings, int p1, int p2)
    {
        int count = strings.Count;
        if (p1 < 0 || p2 < 0 || p1 >= count || (long)p1 + (long)p2 - 1 >= count)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        strings.Reverse(p1, p2);
    }
}