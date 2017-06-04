using System;
namespace _03_Miles_To_Kms
{
    class Program
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double kms = miles * 1.60934;

            Console.WriteLine("{0:f2}", kms);
        }
    }
}
