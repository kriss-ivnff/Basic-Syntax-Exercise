using System;

namespace _04_Beverage_Labels
{
    class Program
    {
        static void Main()
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double energyPer100ml = ((volume / 100.0) * energyContent);
            double sugarPer100ml = ((volume / 100.0) * sugarContent);

            Console.WriteLine($"{volume}ml {productName}:\n" +
                $"{energyPer100ml}kcal, {sugarPer100ml}g sugars");
        }
    }
}
