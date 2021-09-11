using System;

namespace Lab1_Ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Write a program that accepts a number between 1 and 7 from the user and return the
            corresponding day of the week(1- Monday, 2- Tuesday and so on). 
             */
            /*
             * Viết chương trình nhập 1 số từ 1 đến 7 từ người dùng và trả về ngày tương ứng trong tuần
             * VD: (1- Thứ Hai, 2- Thứ Ba, v.v.). 
             */
            Console.WriteLine("Enter 1-7 integer number");
            int number;
            while (true)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number >=1 && number <= 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong again, Enter 1-7 integer number");
                }
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}