using System;
using System.Globalization;

namespace Lab3_Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var employee = new Employee("Nguyen","Tung Bach","Abyss",123,10000000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine("Enter percentage");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bound = {0} VNĐ", employee.bound(n).ToString("#,###", cul.NumberFormat));
        }
    }
}