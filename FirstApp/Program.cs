using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)

        {

            int[] array = { 1, 2, -1, 4, -10 };
            var s = 0;


            for (var i = 0; i < array.Length; i++)
            {
               

                if (array[i] > 0)
                    
                    s = s + 1;
                
            }

            Console.WriteLine(s);
                        

            Console.ReadKey();
        }






    }
}

