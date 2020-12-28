using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Введите число");

            var y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите степень");

            var i = byte.Parse(Console.ReadLine());

            Console.WriteLine(PowerUp(y,i));

            Console.ReadKey();
        }

        static decimal PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1; 
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
                
            }
        }



    }

}










