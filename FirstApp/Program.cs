﻿using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int summ = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                summ = summ + arr[i];
               
               
            }

            Console.WriteLine(summ);
                        

            Console.ReadKey();
        }






    }
}

