using System;

namespace Lab1_Ex5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Write a program to print the factorials of the integers from 1 to 20
             * Viết chương trình in ra giai thừa từ 1 đến 20
             * CD: 4! = 1x2x3x4 = 24
             */
            long giai_thua = 1;
            for (int i = 1; i <= 20; i++)
            {
                giai_thua *= i;
                Console.Write("{0}!={1}\n",i,giai_thua);
            }
        }
    }
}