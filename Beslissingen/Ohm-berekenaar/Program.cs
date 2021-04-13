using System;

namespace Ohm_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 4.4 Ohm-berekenaar
            Console.WriteLine("4.4 Ohm-berekenaar\n");

            Console.WriteLine("\nWhat do you want to calculate?\n[1]Voltage\n[2]Resistance\n[3]Current\n");
            double choice = Convert.ToDouble(Console.ReadLine());

            double current;
            double voltage;
            double resistance;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nYou want to calculate the voltage. First enter the desired current [A]:\n");
                    current = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nFinally enter the desired resistance [Ohm]:\n");
                    resistance = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    voltage = current * resistance;
                    Console.WriteLine($"\nCalculated voltage = {voltage}V.\n");
                    break;
            
                case 2:
                    Console.WriteLine("\nYou want to calculate the resistance. First enter the desired current [A]:\n");
                    current = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nFinally enter the desired voltage [V]:\n");
                    voltage = Convert.ToDouble(Console.ReadLine());
                    resistance = voltage / current;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nCalculated resistance = {resistance}Ohm.\n");
                    break;
            
                case 3:
                    Console.WriteLine("\nYou want to calculate the current. First enter the desired voltage [V]:\n");
                    voltage = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nFinally enter the desired resistance [Ohm]:\n");
                    resistance = Convert.ToDouble(Console.ReadLine());
                    current = voltage / resistance;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nCalculated current = {current}A.\n");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
