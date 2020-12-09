using System;

namespace FirstApp
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch(color)
            {
                case "red":
                   Console.BackgroundColor = ConsoleColor.Red;
                   Console.ForegroundColor = ConsoleColor.Black;

                   Console.WriteLine("Ваш любимы цвет красный!");
                    break;

                case "green":
                   Console.BackgroundColor = ConsoleColor.Green;
                   Console.ForegroundColor = ConsoleColor.Black;

                   Console.WriteLine("Ваш любимый цвет зелёный!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш любимый цвет бирюзовый");
                    break;

                default:
                   Console.BackgroundColor = ConsoleColor.Yellow;
                   Console.ForegroundColor = ConsoleColor.Red;

                   Console.WriteLine("Ваш любимый цвет жёлтый!");
                    break;
            }



            Console.ReadKey();



        }
    }
}
