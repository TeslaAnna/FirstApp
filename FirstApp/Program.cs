using System;

namespace FirstApp
{    
    class Program
    {
        static void Main(string[] args)
        {
            int currentDayInYear = 293;
            bool isLeapYear = false;

            bool isWinter =
                !isLeapYear & (currentDayInYear >= 335 | currentDayInYear <= 59)
                |
                isLeapYear & (currentDayInYear >= 336 | currentDayInYear <= 60);

            Console.WriteLine("Текущее время года - зима: {0}", isWinter);


            Console.ReadKey();



        }
    }
}
