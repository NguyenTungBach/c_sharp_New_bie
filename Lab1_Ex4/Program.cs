using System;

namespace Lab1_Ex4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Write a program to display the first 9 multiples of an integer. N entered from user
             * Viết chương trình hiển thị 9 bội số đầu tiên của 1 số nguyên (nói đơn giản là bảng cửu chương). 
             * N được nhập từ người dùng
             */
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",n, i+1, n*(i+1));
            }
        }
    }
}