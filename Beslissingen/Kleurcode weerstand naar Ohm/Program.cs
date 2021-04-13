using System;

namespace Kleurcode_weerstand_naar_Ohm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 4.5 Kleurcode weerstand naar Ohm
            Console.WriteLine("4.5 Kleurcode weerstand naar Ohm\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Input colors that are accepted: black, brown, red, orange, yellow, green, blue, violet, grey and white.");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nPlease give color of first ring?\n");
            string ring1 = Console.ReadLine();
            int ring1Num = Translate(ring1);

            Console.WriteLine("\nPlease give color of second ring?\n");
            string ring2 = Console.ReadLine();
            int ring2Num = Translate(ring2);

            Console.WriteLine("\nPlease give color of 3th ring?\n");
            string ring3 = Console.ReadLine();
            int ring3Num = Translate(ring3);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nYou want to calculate the resistance with following color rings; {ring1}=({ring1Num}), {ring2}=({ring2Num}) and {ring3}=({ring3Num}).\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            double resistanceValue = (ring1Num * 10 + ring2Num)* Math.Pow(10, ring3Num);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Output: Total resistance value is: {resistanceValue} Ohm");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static int Translate(string ring)
        {
            //do switch here
            //int varToTest = int.Parse(ring);

            switch (ring)
            {
                case "black":
                    return 0;
                case "brown":
                    return 1;
                case "red":
                    return 2;
                case "orange":
                    return 3;
                case "yellow":
                    return 4;
                case "green":
                    return 5;
                case "blue":
                    return 6;
                case "violet":
                    return 7;
                case "grey":
                    return 8;
                case "white":
                    return 9;
                default:
                    return 0;
                    break;
            }

            //int convertedRing = Convert.ToInt32(ring);
            //return convertedRing;
        }
    }
}
