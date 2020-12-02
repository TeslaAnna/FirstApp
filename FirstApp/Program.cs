using System;

namespace FirstApp
{
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

            Console.ReadKey();
        }
    }
}
