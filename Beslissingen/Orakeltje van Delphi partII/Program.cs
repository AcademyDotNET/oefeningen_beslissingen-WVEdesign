using System;

namespace Orakeltje_van_Delphi_partII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.6 Orakeltje van Delphi partII");

            Console.WriteLine("\nPlease input you\'re gender (only [m] and [v] allowed);");
            string gender = Console.ReadLine();

            int age;

            if (gender == "m")
            {
                Console.WriteLine("\nDear male, please input you\'re age (5-120);");
                age = Convert.ToInt32(Console.ReadLine());

                Random randomGenerator = new Random();
                int funeralTime = randomGenerator.Next(age, 121); //getallen tussen de leeftijd en 121 jaar

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nCongratulations male!, You have still {funeralTime-age} years to live, enjoy !\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (gender == "v")
            {
                Console.WriteLine("\nDear female, please input you\'re age (5-150);");
                age = Convert.ToInt32(Console.ReadLine());

                Random randomGenerator = new Random();
                int funeralTime = randomGenerator.Next(age, 151); //getallen tussen de leeftijd en 151 jaar

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nCongratulations female!, You have still {funeralTime-age} years to live, enjoy !\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
