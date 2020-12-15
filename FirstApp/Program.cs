using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        int ch = arr[i];
                        arr[i] = arr[k];
                        arr[k] = ch;
                    }
                }

            }

            foreach(var str in arr)
            {
                Console.Write(str);
            }
                        

            Console.ReadKey();
        }






    }
}

