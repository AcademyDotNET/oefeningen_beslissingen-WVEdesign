using System;

namespace BMI_met_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 4.1 BMI Calculator with if based on 3.1 
            Console.WriteLine("4.1 BMI Calculator with if based on 3.1\n");

            Console.WriteLine("\nPlease give your length [m];");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease give your weight [kg];");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(length, 2);

            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYour BMI =  {bmi}\n");
                Console.WriteLine($"Extra Info: ondergewicht.\n");
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYour BMI =  {bmi}\n");
                Console.WriteLine($"Extra Info: normaal gewicht.\n");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nYour BMI =  {bmi}\n");
                Console.WriteLine($"Extra Info: overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.\n");
            }
            else if (bmi >= 30 && bmi < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYour BMI =  {bmi}\n");
                Console.WriteLine($"Extra Info: Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.\n");
            }
            else if (bmi >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\nYour BMI =  {bmi}\n");
                Console.WriteLine($"Extra Info: ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).\n");
            }
            
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
