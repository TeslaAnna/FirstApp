﻿using System;

namespace FirstApp
{
    class Program
    {
        
        static void Main(string[] args)

        {
            Console.WriteLine("Напишите что-то");

            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");

            var deep = int.Parse(Console.ReadLine());

            for (int i = 0; i < deep; i++)
            {
                Echo(str);
            }

            Console.ReadKey();
        }

        static void Echo(string saidword)
        {
            Console.WriteLine(saidword);
        }

        

    }

}










