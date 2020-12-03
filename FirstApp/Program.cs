using System;

namespace FirstApp
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", Name, Age);

            Console.Write("Enter your birthdate: ");
            var Birthdate = Console.ReadLine();

            Console.WriteLine("Your birthday is {0}", Birthdate);



        }
    }
}
