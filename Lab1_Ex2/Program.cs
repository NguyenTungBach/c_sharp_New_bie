using System;

namespace Lab1_Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program to accept three integer number and find maximun number from three integer.
            // Viết chương trình kiểm tra 3 số nguyên và tìm số lớn nhất trong ba số
            
            // int[] array = { 1, 4, 6 };
            int[] array = new int[3];
            Console.WriteLine("Enter three integer number");
            for (int i = 0; i < 3; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            var max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("max = {0}",max);
        }
    }
}