using System;

namespace SpeedConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            ConvertedSpeeds();
        }
        public static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. MPH to KPH");
            Console.WriteLine("2. KPH to MPH");
            Console.WriteLine("");
        }
        public static void ConvertedSpeeds()
        {
            string again = "y";
            while (again == "y".ToLower())
            {
                Console.WriteLine("Enter a menu option ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter speed in MPH ");
                    double mph = Convert.ToDouble(Console.ReadLine());
                    double kph = SpeedConversionMethods.MphToKph(mph);
                    kph = Math.Round(kph, 2);
                    Console.WriteLine($"Speed is {kph} kph");
                }
                if (option == 2)
                {
                    Console.WriteLine("Enter speed in KPH ");
                    double kph = Convert.ToDouble(Console.ReadLine());
                    double mph = SpeedConversionMethods.KphToMph(kph);
                    mph = Math.Round(mph);
                    Console.WriteLine($"Speed is {mph} mph");
                }
                else
                {
                    Console.WriteLine("You must enter a valid menu number");
                }
                Console.WriteLine("Convert another measurement? (y|n)");
                again = Console.ReadLine();
                if (again == "y")
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
