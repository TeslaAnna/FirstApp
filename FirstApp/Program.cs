using System;

namespace FirstApp
{
    class Program
    {
        
        static void Main(string[] args)

        {
            var someName = "Евгения";
            Console.WriteLine(someName);

            GetName(ref someName);
            Console.WriteLine(someName);

            var someAge = 34;
            Console.WriteLine(someAge);

            ChangeAge(someAge);
            Console.WriteLine(someAge);

            Console.ReadKey();
        }
        
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static void ChangeAge(int age)
        {
            Console.WriteLine("Введите возраст");
            age = Convert.ToInt32(Console.ReadLine());
        }

    }

}










