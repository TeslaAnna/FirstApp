﻿using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {
            var (name, age) = ("Евгения", "27");

            Console.WriteLine("Моё имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);


            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.Write("Введите ваш возраст цифрами: ");
            age = Console.ReadLine();


            Console.WriteLine("Ваше имя: {0}", name);
            
            Console.WriteLine("Ваш возраст: {0} ", age);
            

            

            Console.ReadKey();
        }

    }

}










