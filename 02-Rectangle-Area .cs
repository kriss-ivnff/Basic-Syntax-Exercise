using System;

namespace _02_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double area = num1 * num2;

            Console.WriteLine("{0:f2}", (area));
        }
    }
}
