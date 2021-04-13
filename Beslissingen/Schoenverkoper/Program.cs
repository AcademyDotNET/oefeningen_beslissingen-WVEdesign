using System;

namespace Schoenverkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 4.2 Schoenverkoper 
            Console.WriteLine("4.2 Schoenverkoper\n");

            Console.WriteLine("\nHow many pair of shoes do you wish to buy?");
            double nShoes = Convert.ToDouble(Console.ReadLine());

            double priceTotal;

            if (nShoes < 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                priceTotal = nShoes * 20;
                Console.WriteLine($"\nYou wish to buy {nShoes} shoes for EUR{priceTotal}.\n");
            }
            else if (nShoes >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                priceTotal = 9* 20 + (nShoes - 9) * 10;
                Console.WriteLine($"\nYou wish to buy {nShoes} shoes for EUR{priceTotal}.\n");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
