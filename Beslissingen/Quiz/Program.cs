//Bron Quizvragen: https://raadsels.nu/grappige-quizvragen/
//question1; Hoeveel scheten laat een mens gemiddeld per jaar? 3000, 5000, 5500 of 7000?
//antwoord1; Gemiddeld laat iedereen zo’n 7000 scheten per jaar. Maar zijn er ook mensen 
//           die er met gemak 10.000 per jaar laten!

//question2; Hoe lang leef je nog nadat je hoofd eraf is gehakt d.m.v. een guillotine? 0 seconden, 15 seconden of 30 seconden?
//antwoord2; Gemiddeld nog zo’n 15 seconden.

//question3; Welk fruit is vernoemd naar een vogel? Durian, citroen, kiwi, azarole of Pink Lady?
//antwoord3; De kiwi is vernoemd naar een vogel uit Nieuw-Zeeland.

using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.9 Quiz");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nWelcome to the fun-quiz., Press any key to continue to the quiz...\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();

            int questionNumber = 1;
            int score = 0;

            while(questionNumber < 4)
            { 
                switch (questionNumber)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Vraag1: Hoeveel scheten laat een mens gemiddeld per jaar? 3000, 5000, 5500 of 7000? [a, b, c of d]\n");
                        Console.WriteLine("a) 3000");
                        Console.WriteLine("b) 5000");
                        Console.WriteLine("c) 5500");
                        Console.WriteLine("d) 7000\n");
                        Console.Write("Antwoord: ");
                        string answer1 = Console.ReadLine();
                        if (answer1 == "d")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Yes, your answer is correct!, press Enter to continue");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            score += 2;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ooooh, your answer is wrong, press Enter to continue");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            score--;
                        }
                        Console.ReadKey();
                        questionNumber = 2;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Vraag2: Hoe lang leef je nog nadat je hoofd eraf is gehakt d.m.v. een guillotine? [a, b, c of d]\n");
                        Console.WriteLine("a) 0");
                        Console.WriteLine("b) 5");
                        Console.WriteLine("c) 15");
                        Console.WriteLine("d) 30\n");
                        Console.Write("Antwoord: ");
                        string answer2 = Console.ReadLine();
                        if (answer2 == "c")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Yes, your answer is correct!, press Enter to continue");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            score = score + 2;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ooooh, your answer is wrong, press Enter to continue");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            score--;
                        }
                        Console.ReadKey();
                        questionNumber = 3;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vraag3: Welk fruit is vernoemd naar een vogel? [a, b, c of d]\n");
                        Console.WriteLine("a) durian");
                        Console.WriteLine("b) cherimoya");
                        Console.WriteLine("c) kiwi");
                        Console.WriteLine("d) Pink Lady\n");
                        Console.Write("Antwoord: ");
                        string answer3 = Console.ReadLine();
                        if (answer3 == "c")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Yes, your answer is correct!, press Enter to continue");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            score = score + 2;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ooooh, your answer is wrong, press Enter to continue");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            score--;
                        }
                        Console.ReadKey();
                        questionNumber = 4;
                        break;
                    default:
                        questionNumber = 1;
                        break;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Thank you for playing the fun-quiz. Your total score is: {score}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
