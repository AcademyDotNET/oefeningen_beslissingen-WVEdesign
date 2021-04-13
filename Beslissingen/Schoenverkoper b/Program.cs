using System;

namespace Schoenverkoper_b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 4.3 Schoenverkoper - opgave b 
            Console.WriteLine("4.3 Schoenverkoper - opgave b\n");

            Console.WriteLine("\nFrom how many pair of shoes should discount start?");
            double discStarts = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nHow many pair of shoes do you wish to buy?");
            double nShoes = Convert.ToDouble(Console.ReadLine());
            
            double priceTotal;

            if (nShoes < discStarts)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                priceTotal = nShoes * 20;
                Console.WriteLine($"\nYou wish to buy {nShoes} shoes for EUR{priceTotal}.\n");
            }
            else if (nShoes >= discStarts)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                priceTotal = (discStarts * 20) + (nShoes - discStarts) * 10;
                Console.WriteLine($"\nYou wish to buy {nShoes} shoes for EUR{priceTotal}.\n");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
