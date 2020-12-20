﻿using System;

namespace FirstApp
{
    class Program
    {
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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
            var FavColors = new string[3];

            for (int i = 0; i < FavColors.Length; i++)
            {
                FavColors[i] = ShowColor();
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










