using System;
using System.Collections.Generic;

namespace Lab3_Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            Atom atom = new Atom();
            List<Atom> list = new List<Atom>();
            while (true)
            {
                Console.Write("Enter atomic number : ");
                atom.number = Convert.ToInt32(Console.ReadLine());
                if (atom.number == 0)
                {
                    Console.WriteLine("No Sym Name Weight");
                    break;
                }
                Console.Write("Enter symbol : ");
                atom.symbol = Console.ReadLine();
                Console.Write("Enter full name : ");
                atom.fullName = Console.ReadLine();
                Console.Write("Enter weight : ");
                atom.weight = Convert.ToSingle(Console.ReadLine());
                if (!atom.accept())
                {
                    break;
                }
                list.Add(atom);
            }
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < list.Count; i++)
            {
                list[i].display();
            }
        }
    }
}