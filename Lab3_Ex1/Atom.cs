using System;

namespace Lab3_Ex1
{
    public class Atom
    {
        public int number { get; set; }
        public string symbol { get; set; }
        public string fullName { get; set; }
        public float weight { get; set; }
        
        public bool accept()
        {
            if (string.IsNullOrEmpty(Convert.ToString(number)) || number ==0 || number >10)
            {
                Console.WriteLine("No Sym Name Weight");
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(symbol)))
            {
                Console.WriteLine("Sym can be null");
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(fullName)))
            {
                Console.WriteLine("Name can be null");
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(weight)))
            {
                Console.WriteLine("Weight can be null");
                return false;
            }
            return true;
        }

        public void display()
        {
            Console.WriteLine("{0} {1} {2} {3}", number,symbol,fullName,weight);
        }
    }
}