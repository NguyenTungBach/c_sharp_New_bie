using System;

namespace Lab1_Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program to enter: name, address, phone and display these information.
            // Viết 1 chương trình nhập: name, address, phone và hiển thị những thông tin đó
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter address");
            var address = Console.ReadLine();
            Console.WriteLine("Enter phone");
            var phone = Console.ReadLine();
            Console.WriteLine("name = {0} \naddress = {1} \nphone = {2}",name,address,phone);
        }
    }
}