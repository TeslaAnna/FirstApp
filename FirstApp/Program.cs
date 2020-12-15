using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= arr.GetUpperBound(1); k++)
                {
                    Console.Write(arr[i, k] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= arr.GetUpperBound(1); k++)
                {


                    for (int l = k + 1; l <= arr.GetUpperBound(1); l++)
                    {

                        if (arr[i, k] > arr[i, l])
                        {
                            int ch = arr[i, k];
                            arr[i, k] = arr[i, l];
                            arr[i, l] = ch;
                        }
                    }
                    Console.Write(arr[i, k] + " ");
                }

                Console.WriteLine();
             
            }

            






            Console.ReadKey();
        }

    }

}










