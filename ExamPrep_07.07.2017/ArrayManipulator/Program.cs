using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            var line = Console.ReadLine();

            while (line != "End")
            {
                string[] input = line.Split(' ').ToArray();

                people.Add(ReadPerson(input));
                line = Console.ReadLine();
            }
            foreach (var item in people.OrderBy(a => a.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }

        private static Person ReadPerson(string[] input)
        {
            Person persone = new Person();
            persone.Name = input[0];
            persone.Id = input[1];
            persone.Age = int.Parse(input[2]);

            return persone;
        }
    }
}