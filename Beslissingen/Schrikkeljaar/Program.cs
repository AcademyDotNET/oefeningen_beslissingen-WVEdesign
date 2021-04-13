using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4.10 SchrikkeljaarChecker");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nPlease give a year to check? ex.: 1997\n");
            double year = Convert.ToDouble(Console.ReadLine());

            /* info: https://docs.microsoft.com/nl-nl/office/troubleshoot/excel/determine-a-leap-year
             1   Als het jaar gelijkmatig deelbaar is door 4, ga dan naar stap 2. Ga anders naar stap 5.
             2   Als het jaar gelijkmatig deelbaar is door 100, ga dan naar stap 3. Ga anders naar stap 4.
             3   Als het jaar gelijkmatig deelbaar is door 400, ga dan naar stap 4. Ga anders naar stap 5.
             4   Het jaar is een schrikkeljaar (het heeft 366 dagen).
             5   Het jaar is geen schrikkeljaar (het heeft 365 dagen).
            */

            int stap = 1;
            bool answerFound = false;

            while (answerFound != true)
            {
                switch (stap)
                {
                    case 1: // Als het jaar gelijkmatig deelbaar is door 4, ga dan naar stap 2. Ga anders naar stap 5.
                        if (year % 4 == 0)
                        {
                            stap = 2;
                        }
                        else
                        {
                            stap = 5;
                        }
                        break;
                    case 2: // Als het jaar gelijkmatig deelbaar is door 100, ga dan naar stap 3. Ga anders naar stap 4.
                        if (year % 100 == 0)
                        {
                            stap = 3;
                        }
                        else
                        {
                            stap = 4;
                        }
                        break;
                    case 3: // Als het jaar gelijkmatig deelbaar is door 400, ga dan naar stap 4. Ga anders naar stap 5.
                        if (year % 400 == 0)
                        {
                            stap = 4;
                        }
                        else
                        {
                            stap = 5;
                        }
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nJa, {year} is een schrikkeljaar");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        answerFound = true;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nNee, {year} is geen schrikkeljaar");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        answerFound = true;
                        break;
                    default:
                        stap = 1;
                        break;
                }
            }
        }
    }
}


