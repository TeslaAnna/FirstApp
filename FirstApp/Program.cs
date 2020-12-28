using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)

        {
            int y = 20;

            Console.WriteLine(Factorial(y));

            Console.ReadKey();
        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }



    }

}










