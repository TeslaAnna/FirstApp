using System;

namespace FirstApp
{
    class Program
    {
        static string ShowColors(string username)
        {
            Console.WriteLine("{0} Напишите свой любимый цвет на английском с маленькой буквы", username);
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your color is yellow!");
                    break;
            }



            return color;
        }
        static void Main(string[] args)

        {
            var (name, age) = ("Анна", 34);

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0} ", age);

            var FavColors = new string[3];

            for (int i = 0; i < FavColors.Length; i++)
            {
                FavColors[i] = ShowColors(name);
            }

            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in FavColors)
            {
                Console.WriteLine(color);
            }





            Console.ReadKey();
        }

    }

}










