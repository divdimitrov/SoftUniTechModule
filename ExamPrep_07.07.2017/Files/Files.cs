using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Jarvis
{
    class Arm
    {
        public int Energy { get; set; }
        public int ArmReachDistance { get; set; }
        public int CountFingers { get; set; }
    }

    class Leg
    {
        public int Energy { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
    }

    class Torso
    {
        public int Energy { get; set; }
        public double ProcessorSize { get; set; }
        public string Material { get; set; }
    }

    class Head
    {
        public int Energy { get; set; }
        public int Iq { get; set; }
        public string Skin { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Head> heads = new List<Head>();
            List<Leg> legs = new List<Leg>();
            List<Arm> arms = new List<Arm>();
            List<Torso> body = new List<Torso>();
            ulong totalPower = ulong.Parse(Console.ReadLine());
            var line = Console.ReadLine();

            while (line != "Assemble!")
            {
                string[] input = line.Split(' ').ToArray();

                string part = input[0];

                switch (part)
                {
                    case "Arm":
                        if (arms.Count == 0)
                        {
                            arms.Add(ReadArm(input));
                        }
                        else if (arms.Count == 1)
                        {
                            arms.Add(ReadArm(input));
                        }
                        else if (ReadArm(input).Energy < arms[0].Energy)
                        {
                            arms[0] = ReadArm(input);
                        }
                        break;
                    case "Head":
                        if (heads.Count == 0)
                        {
                            heads.Add(ReadHead(input));
                        }
                        else if (ReadHead(input).Energy < heads[0].Energy)
                        {
                            heads[0] = ReadHead(input);
                        }
                        break;

                    case "Torso":
                        if (body.Count == 0)
                        {
                            body.Add(ReadTorso(input));
                        }
                        else
                        {
                            if (ReadTorso(input).Energy < body[0].Energy)
                            {
                                body[0] = ReadTorso(input);
                            }
                        }
                        break;

                    case "Leg":
                        if (legs.Count == 0)
                        {
                            legs.Add(ReadLeg(input));
                        }
                        else if (legs.Count == 1)
                        {
                            legs.Add(ReadLeg(input));
                        }
                        else
                        {
                            if (ReadLeg(input).Energy < legs[0].Energy)
                            {
                                legs[0] = ReadLeg(input);
                            }
                        }
                        break;

                    default:
                        break;
                }
                line = Console.ReadLine();

            }

            if (legs.Count <= 1 || arms.Count <= 1 || heads.Count == 0 || body.Count == 0)
            {
                Console.WriteLine("We need more parts!");
                return;
            }

            ulong neededPower = (ulong)heads[0].Energy + (ulong)body[0].Energy + (ulong)legs[0].Energy +
                (ulong)legs[1].Energy + (ulong)arms[0].Energy + (ulong)arms[1].Energy;

            if (neededPower > totalPower)
            {
                Console.WriteLine("We need more power!");
                return;
            }

            Console.WriteLine("Jarvis:");
            PrintHead(heads);
            PrintTorso(body);
            PrintArm(arms);
            PrintLegs(legs);
        }

        private static void PrintLegs(List<Leg> legs)
        {
            foreach (var item in legs.OrderBy(a => a.Energy))
            {
                Console.WriteLine($"#Leg:\n###Energy consumption: {item.Energy}\n###Strength: " +
                $"{item.Strenght}\n###Speed: {item.Speed}");
            }
        }

        private static void PrintArm(List<Arm> arms)
        {
            foreach (var item in arms.OrderBy(a => a.Energy))
            {
                Console.WriteLine($"#Arm:\n###Energy consumption: {item.Energy}\n###Reach: " +
               $"{item.ArmReachDistance}\n###Fingers: {item.CountFingers}");
            }
        }

        private static void PrintTorso(List<Torso> body)
        {
            Console.WriteLine($"#Torso:\n###Energy consumption: {body[0].Energy}\n###Processor size: " +
                $"{body[0].ProcessorSize:f1}\n###Corpus material: {body[0].Material}");
        }

        private static void PrintHead(List<Head> heads)
        {
            Console.WriteLine($"#Head:\n###Energy consumption: {heads[0].Energy}\n###IQ: {heads[0].Iq}\n###Skin material: {heads[0].Skin}");
        }

        private static Leg ReadLeg(string[] input)
        {
            Leg leg = new Leg();
            leg.Energy = int.Parse(input[1]);
            leg.Strenght = int.Parse(input[2]);
            leg.Speed = int.Parse(input[3]);

            return leg;
        }

        private static Torso ReadTorso(string[] input)
        {
            Torso torso = new Torso();

            torso.Energy = int.Parse(input[1]);
            torso.ProcessorSize = double.Parse(input[2]);
            torso.Material = input[3];

            return torso;
        }

        private static Head ReadHead(string[] input)
        {
            Head head = new Head();
            head.Energy = int.Parse(input[1]);
            head.Iq = int.Parse(input[2]);
            head.Skin = input[3];

            return head;
        }

        private static Arm ReadArm(string[] input)
        {
            Arm arm = new Arm();
            arm.Energy = int.Parse(input[1]);
            arm.ArmReachDistance = int.Parse(input[2]);
            arm.CountFingers = int.Parse(input[3]);

            return arm;
        }
    }
}