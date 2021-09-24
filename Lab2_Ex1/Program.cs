using System;
using System.Collections.Generic;

namespace Lab2_Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] Arr = new int[] {1,9,3,4,5,6,7,8,7};
            List<int> listArrayNeedSum = new List<int>();
            int digitKt = Arr[Arr.Length - 1];
            Console.WriteLine("Số cần kiểm tra = {0}",Arr[Arr.Length-1]);
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 1; i < Arr.Length ; i+=2)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 1; i < Arr.Length ; i+=2)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("__________________");
            for (int i = 1; i < Arr.Length-1 ; i+=2)
            {
                Console.Write((Arr[i]+Arr[i]) + " ");
                listArrayNeedSum.Add(Arr[i] + Arr[i]);
            }
            Console.WriteLine(" ");
            
            int tong1 = 0;
            int tong2 = 0;
            for (int i = 0; i < listArrayNeedSum.Count ; i++)
            {
                if (listArrayNeedSum[i]>10)
                {
                    while (listArrayNeedSum[i] > 0) {
                        int digit = listArrayNeedSum[i] % 10;
                        // do something with digit
                        listArrayNeedSum[i] /= 10;
                        // Console.WriteLine(digit);
                        tong1 += digit;
                    }
                }
                else
                {
                    tong2 += listArrayNeedSum[i];
                }
            }
            Console.WriteLine("the digits of each sum = {0}", (tong1+tong2));
            List<int> listLe = new List<int>(); 
            int tong3 = 0;
            for (int i = Arr.Length-3; i >= 0; i-=2)
            {
                tong3 += Arr[i];
            }
            Console.WriteLine("the other alternates = {0}", tong3);
            Console.WriteLine("Next highest integer multiple of 10 is {0}", tong3+tong1+tong2);
            
            int kt = 0;
            int tongChung = tong3 + tong1 + tong2;
            while (tongChung%10 !=0)
            {
                if (tongChung%10 !=0)
                {
                    tongChung++;
                    kt++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Difference = {0}", kt);
            if (digitKt==kt)
            {
                Console.WriteLine("This is a valid SIN. ");
            }
            else
            {
                Console.WriteLine("This is not a valid SIN. ");
            }
        }
    }
}