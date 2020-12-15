using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            var s = 0;


            for (var i = 0; i <= arr.GetUpperBound(0); i++)
            {

                for (var k = 0; k <= arr.GetUpperBound(1); k++)
                {
                    if (arr[i, k] > 0)

                        s++;
                }
                
            }

            Console.WriteLine(s);
                        

            Console.ReadKey();
        }






    }
}

