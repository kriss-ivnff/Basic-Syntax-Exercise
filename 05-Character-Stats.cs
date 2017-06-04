using System;

namespace _05_Character_Stats
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);

            Console.Write("Health: ");

            Console.Write("|");

            for (int i = 0; i < 1; i++)
            {
                Console.Write(new string ('|', currentHealth) + new string ('.', maxHealth - currentHealth));
            }

            Console.WriteLine("|");

            Console.Write("Energy: ");

            Console.Write("|");

            for (int i = 0; i < 1; i++)
            {
                Console.Write(new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy));
            }

            Console.WriteLine("|");

        }
    }
}
