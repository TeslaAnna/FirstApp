﻿using System;

namespace FirstApp
{
    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tyesday,
        Wednesday,
        Thursday,
        Friday,
        Saterday,
        Sunday
    }

    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Anna";
            byte MyAge = 34;
            bool HaveIApet = false;
            double MyShoeSize = 35;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.WriteLine("LongMin {0}", long.MinValue);
            Console.WriteLine("LongMax {0}", long.MaxValue);

            Console.WriteLine();
            Console.WriteLine("\t Привет, \n мир!");
            Console.WriteLine($"Мой возраст {MyAge}");

            Console.ReadKey();
        }
    }
}
