using System;

namespace _01_Debit_Card_Number
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3= int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());


            Console.WriteLine(String.Format("{0:0000} {1:0000} {2:0000} {3:0000}", num1 , num2, num3, num4));
        }
    }
}
