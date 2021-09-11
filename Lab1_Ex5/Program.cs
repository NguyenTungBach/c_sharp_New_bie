using System;

namespace Lab1_Ex5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Write a program to print the factorials of the integers from 1 to 20
             * Viết chương trình in ra thừa số các số nguyên tố từ 1 đến 20
             * Thừa số là số chia hết cho 1 và chính nó
             */
            for (int i = 1; i < 20; i++)
            {
                var dem = 0;
                if (i==1)
                {
                    dem = 1;
                }
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0 )
                    { 
                        dem = 1;
                    }
                }
                if (dem==0)
                {
                    Console.Write("{0}, ",i);
                }
            }
        }
    }
}